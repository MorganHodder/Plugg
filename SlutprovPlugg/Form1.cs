using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SlutprovPlugg
{
    public partial class Form1 : Form
    {
        public List<Room> RoomsCalc = new List<Room>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Room newRoom = new Room(tbxName.Text, Convert.ToDouble(tbxLength.Text), Convert.ToDouble(tbxWidth.Text));
            RoomsCalc.Add(newRoom);
            lbxRooms.Items.Add($"{newRoom.name}: {newRoom.length} m x {newRoom.width} m");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(RoomsCalc.Count > 0)
            {
                RoomsCalc.RemoveAt(RoomsCalc.Count - 1);
                lbxRooms.Items.RemoveAt(lbxRooms.Items.Count - 1);
            }
        }

        private void btnLargest_Click(object sender, EventArgs e)
        {
            var AreaLargest = RoomsCalc.OrderByDescending(x => x.Area);
            tbxLargest.Text = $"{AreaLargest.FirstOrDefault().name}: {AreaLargest.FirstOrDefault().Area.ToString()} kvadratmeter";
        }
    }

    public class Room
    {
        public string name { get; set; }
        public double length { get; set; }
        public double width { get; set; }
        
        public Room(string n, double l, double w)
        {
            name = n; length = l; width = w;
        }

        public double Area { get { return length * width; } }
    }
}