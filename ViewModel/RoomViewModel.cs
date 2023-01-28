using HCI.Model;
using HCI.Pages.Rooms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HCI.ViewModel
{
    public class RoomViewModel : BindableBase
    {
        public ObservableCollection<Room> Rooms { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand OpenCommand { get; set; }
        private Room selectedRoom;
        private string nText;
        private int iText;
        private bool aText;
        private string tText;
        private int oText;

        public ObservableCollection<RoomReport> Dates { get; set; }
        private RoomReport currentNote = new RoomReport();

        public MyICommand AddNoteCommand { get; set; }

        public RoomViewModel()
        {
            LoadRooms();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            AddCommand = new MyICommand(OnAdd);
            OpenCommand = new MyICommand(OnOpen, CanDelete);

            Dates = new ObservableCollection<RoomReport>();
            AddNoteCommand = new MyICommand(OnAdd1);
        }

        public RoomReport CurrentNote
        {
            get { return currentNote; }
            set
            {
                currentNote = value;
                OnPropertyChanged("CurrentNote");
            }
        }

        public void OnAdd1()
        {

            CurrentNote.Validate();
            if (CurrentNote.IsValid)
            {
                PdfDocument doc = new PdfDocument();
                doc.PageSettings.Orientation = PdfPageOrientation.Landscape;
                doc.PageSettings.Margins.All = 50;
                PdfPage page = doc.Pages.Add();
                PdfGrid pdfGrid = new PdfGrid();
                PdfGraphics graphics = page.Graphics;

                PdfBrush solidBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                RectangleF bounds = new RectangleF(50, 0, 50, 50);
                bounds = new RectangleF(0, bounds.Bottom + 10, graphics.ClientSize.Width, 30);
                //Draws a rectangle to place the heading in that region.
                graphics.DrawRectangle(solidBrush, bounds);
                //Creates a font for adding the heading in the page
                PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 16);
                //Creates a text element to add the invoice number
                PdfTextElement element = new PdfTextElement("Room report", subHeadingFont);
                element.Brush = PdfBrushes.White;

                //Draws the heading on the page
                PdfLayoutResult result = element.Draw(page, new PointF(10, bounds.Top + 8));
                string currentDate = "DATE " + CurrentNote.From.ToString("dd/MM/yyyy") + '-' + CurrentNote.To.ToString("dd/MM/yyyy") + '.';
                //Measures the width of the text to place it in the correct location
                SizeF textSize = subHeadingFont.MeasureString(currentDate);
                PointF textPosition = new PointF(graphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);
                //Draws the date by using DrawString method
                graphics.DrawString(currentDate, subHeadingFont, element.Brush, textPosition);


                    Room room2 = new Room { Name = "OP1", Id = 1, Active = true, Type = "Operation room", OccupationTime = 20 };
                    Room room3 = new Room { Name = "OP2", Id = 2, Active = true, Type = "Operation room", OccupationTime = 10 };
                    Room room4 = new Room { Name = "OP3", Id = 3, Active = false, Type = "Operation room", OccupationTime = 0 };
                    Room room5 = new Room { Name = "RH1", Id = 4, Active = false, Type = "Rest hall", OccupationTime = 0 };

                    List<Room> rooms = new List<Room>();
                    rooms.Add(room2);
                    rooms.Add(room3);
                    rooms.Add(room4);
                    rooms.Add(room5);

                //Creates a PDF grid
                PdfGrid grid = new PdfGrid();
                //Adds the data source
                grid.DataSource = rooms;
                //Creates the grid cell styles
                PdfGridCellStyle cellStyle = new PdfGridCellStyle();
                cellStyle.Borders.All = PdfPens.White;
                PdfGridRow header = grid.Headers[0];
                //Creates the header style
                PdfGridCellStyle headerStyle = new PdfGridCellStyle();
                headerStyle.Borders.All = new PdfPen(new PdfColor(126, 151, 173));
                headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                headerStyle.TextBrush = PdfBrushes.White;
                headerStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 16f, PdfFontStyle.Regular);

                //Adds cell customizations
                for (int i = 0; i < header.Cells.Count; i++)
                {
                        header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                }

                //Applies the header style
                header.ApplyStyle(headerStyle);
                cellStyle.Borders.Bottom = new PdfPen(new PdfColor(217, 217, 217), 0.70f);
                cellStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14, PdfFontStyle.Regular);
                cellStyle.TextBrush = new PdfSolidBrush(new PdfColor(131, 130, 136));
                //Creates the layout format for grid
                PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat();
                // Creates layout format settings to allow the table pagination
                layoutFormat.Layout = PdfLayoutType.Paginate;
                //Draws the grid to the PDF page.
                PdfGridLayoutResult gridResult = grid.Draw(page, new RectangleF(new PointF(0, result.Bounds.Bottom + 40), new SizeF(graphics.ClientSize.Width, graphics.ClientSize.Height - 100)), layoutFormat);

                doc.Save("C:/output/Output.pdf");
                System.Diagnostics.Process.Start("C:/output/Output.pdf");
            }
        }

        public void OnOpen()
        {
            RoomsWithEquipment rwe = new RoomsWithEquipment();
            rwe.Show();
        }

        public Room getRoomByName(String name)
        {

            foreach(Room room in Rooms)
            {
                if(room.Name == name)
                {
                    return room;
                }
            }    

            return null;
        }

        public ObservableCollection<Room> getAll()
        {
            return Rooms;
        }

        public List<Room> getAllRoomsList()
        {
            return Rooms.ToList<Room>();
        }

        public Room SelectedRoom
        {
            get { return selectedRoom; }
            set
            {
                selectedRoom = value;
                DeleteCommand.RaiseCanExecuteChanged(); //try to comment 
                OpenCommand.RaiseCanExecuteChanged(); //try to comment 
            }
        }

        public void LoadRooms()
        {
            ObservableCollection<Room> rooms =
                new ObservableCollection<Room>();

            rooms.Add(new Room { Name = "OP1", Id = 1, Active = true, Type = "Operation room", OccupationTime = 20 });
            rooms.Add(new Room { Name = "OP2", Id = 2, Active = true, Type = "Operation room", OccupationTime = 10 });
            rooms.Add(new Room { Name = "OP3", Id = 3, Active = false, Type = "Operation room", OccupationTime = 0 });
            rooms.Add(new Room { Name = "RH1", Id = 4, Active = false, Type = "Rest hall", OccupationTime = 0 });

            Rooms = rooms;
        }

        private bool CanDelete()
        {
            return SelectedRoom != null;
        }

        private void OnDelete()
        {
            Rooms.Remove(SelectedRoom);
        }

        public string NText
        {
            get { return nText; }
            set
            {
                if (nText != value)
                {
                    nText = value;
                    OnPropertyChanged("NText");
                }
            }
        }

        public int IText
        {
            get { return iText; }
            set
            {
                if (iText != value)
                {
                    iText = value;
                    OnPropertyChanged("IText");
                }
            }
        }

        public bool AText
        {
            get { return aText; }
            set
            {
                if (aText != value)
                {
                    aText = value;
                    OnPropertyChanged("AText");
                }
            }
        }

        public string TText
        {
            get { return tText; }
            set
            {
                if (tText != value)
                {
                    tText = value;
                    OnPropertyChanged("TText");
                }
            }
        }

        public int OText
        {
            get { return oText; }
            set
            {
                if (oText != value)
                {
                    oText = value;
                    OnPropertyChanged("OText");
                }
            }
        }

        private void OnAdd()
        {
            Rooms.Add(new Room { Name = NText, Id = IText, Active = AText, Type = TText, OccupationTime = OText});
        }
        
    }
}
