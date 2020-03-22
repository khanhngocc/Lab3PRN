using Lab3PRN.DAO;
using Lab3PRN.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3PRN
{
    public partial class AdminForm : Form
    {
        AiplaneDAO aiplaneDAO = new AiplaneDAO();
        FlightDAO flightDAO = new FlightDAO();
        InboxDAO inboxDAO = new InboxDAO();
        BookingDAO bookingDAO = new BookingDAO();
        List<Airplane> airplanes;
        List<Flight> flights;
        List<Inbox> inboxes;
        
        public AdminForm()
        {
            InitializeComponent();
        }

        public bool IsInt(TextBox textBox)
        {
            String text_num = textBox.Text;

            try
            {
                int num = Int32.Parse(text_num);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool IsFloat(TextBox textBox)
        {
            String text_num = textBox.Text;

            try
            {
                float num = float.Parse(text_num);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsEmpty(TextBox textBox)
        {
            if (textBox.TextLength <= 0)
                return true;

            return false;
        }

        public bool isExistedAirplane(int id)
        {
            foreach(Airplane airplane in airplanes)
            {
                if (airplane.Id == id)
                    return true;
            }

            return false;
        }

        public bool isExistedFlight(int id)
        {
            foreach (Flight f in flights)
            {
                if (f.Id == id)
                    return true;
            }

            return false;
        }


        public bool isExistedInbox(int id)
        {
            foreach (Inbox i in inboxes)
            {
                if (i.Id == id)
                    return true;
            }

            return false;
        }

        public void updateDatagridInbox()
        {
            dataGridInbox.DataSource = null;
            dataGridInbox.DataSource = inboxDAO.GetAllInbox();
            inboxes = inboxDAO.GetAllInbox();
        }

        public void updateDatagridBooking()
        {
            dataGridBooking.DataSource = null;
            dataGridBooking.DataSource = bookingDAO.GetAllBooking();
           
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            updateDatagridAirplane();
            updateDatagridFlight();
            loadDataComboAirplane();
            loadCity();
            comboDirection.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
            updateDatagridInbox();
            updateDatagridBooking();

        }

        public void loadDataComboAirplane()
        {
            List<KeyValuePair<int, String>> data_airplane = new List<KeyValuePair<int, String>>();
            foreach (Airplane c in airplanes)
            {
                data_airplane.Add(new KeyValuePair<int, String>(c.Id, c.Name));
            }
            comboAirplane.DataSource = null;
            comboAirplane.Items.Clear();
            // Bind the combobox
            comboAirplane.DataSource = new BindingSource(data_airplane, null);
            comboAirplane.DisplayMember = "Value";
            comboAirplane.ValueMember = "Key";
            
        }
      

        private void dataGridAirplane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // click out side table data
                return;

            int ID = Convert.ToInt32(dataGridAirplane.Rows[e.RowIndex].Cells[0].Value.ToString());
            String name = dataGridAirplane.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdAirplane.Text = ID + "";
            txtNameAirplane.Text = name;
        }


        public void updateDatagridAirplane()
        {
            dataGridAirplane.DataSource = null;
            dataGridAirplane.DataSource = aiplaneDAO.GetAllAriplane();
            airplanes = aiplaneDAO.GetAllAriplane();
        }


        public void updateDatagridFlight()
        {
            dataGridFlight.DataSource = null;
            dataGridFlight.DataSource = flightDAO.GetAllFlight();
            flights = flightDAO.GetAllFlight();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsInt(txtIdAirplane) == false)
            {
                MessageBox.Show("Id is not an integer");
                txtIdAirplane.Focus();
                return;
            }

            if (IsEmpty(txtNameAirplane))
            {
                MessageBox.Show("Text is empty");
                txtNameAirplane.Focus();
                return;
            }

            int id = Int32.Parse(txtIdAirplane.Text);
           

            if (isExistedAirplane(id) == false)
            {
                String name = txtNameAirplane.Text;
                Airplane airplane = new Airplane();
                airplane.Id = id;
                airplane.Name = name;
                aiplaneDAO.insertAirPlane(airplane);
                MessageBox.Show("Add successfully");
                clearData();
                updateDatagridAirplane();
                loadDataComboAirplane();
            }
            else
            {
                MessageBox.Show("duplicated id");
            }
        }

        public void clearData()
        {
            txtIdAirplane.Text = "";
            txtNameAirplane.Text = "";
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (IsInt(txtIdAirplane) == false)
            {
                MessageBox.Show("Id is not an integer");
                txtIdAirplane.Focus();
                return;
            }

            int id = Int32.Parse(txtIdAirplane.Text);

            if (isExistedAirplane(id) == true)
            {
                aiplaneDAO.deleteAirPlane(id);
                MessageBox.Show("Remove successfully");
                clearData();
                updateDatagridAirplane();
                loadDataComboAirplane();
            }
            else
            {
                MessageBox.Show("id not exist in list");
            }
        }

        

        public void loadCity()
        {
            RegionInfo country = new RegionInfo(new CultureInfo("en-US", false).LCID);



            List<string> countryNames = new List<string>();

            foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))

            {

                country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);

                countryNames.Add(country.DisplayName.ToString());

            }

           
            comboDCountry.DataSource = new BindingSource(countryNames,null);
           
            comboACountry.DataSource = new BindingSource(countryNames, null);
        }

        public void clearDataFlight()
        {
            txtFlightId.Text = "";
            txt_dep_time.Text = "";
            txt_arr_time.Text = "";
            txt_dep_date.Text = "";
            txt_arr_date.Text = "";
            comboDirection.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
            txtPrice.Text = "";
            txtNoSeat.Text = "";
        }



        private void btnFAdd_Click(object sender, EventArgs e)
        {
            if (IsInt(txtFlightId) == false)
            {
                MessageBox.Show("Id is not an integer");
                txtFlightId.Focus();
                return;
            }

            if (IsEmpty(txt_dep_time))
            {
                MessageBox.Show("Text is empty");
                txt_dep_time.Focus();
                return;
            }

            if (IsEmpty(txt_arr_time))
            {
                MessageBox.Show("Text is empty");
                txt_arr_time.Focus();
                return;
            }

            if (IsEmpty(txt_dep_date))
            {
                MessageBox.Show("Text is empty");
                txt_dep_date.Focus();
                return;
            }

            if (IsEmpty(txt_arr_date))
            {
                MessageBox.Show("Text is empty");
                txt_arr_date.Focus();
                return;
            }

            if (IsFloat(txtPrice) == false)
            {
                MessageBox.Show("price is not an float");
                txtPrice.Focus();
                return;
            }

            if (IsInt(txtNoSeat) == false)
            {
                MessageBox.Show("No Seat is not an integer");
                txtNoSeat.Focus();
                return;
            }

            int id = Int32.Parse(txtFlightId.Text);


            if (isExistedFlight(id) == false)
            {
                Flight flight = new Flight();
                flight.Id = id;
                flight.Depart_time = txt_dep_time.Text;
                flight.Arrival_time = txt_arr_time.Text;
                flight.Depart_date = txt_dep_date.Text;
                flight.Arrival_date = txt_arr_date.Text;
                flight.Depart_country = comboDCountry.SelectedItem.ToString();
                flight.Arrival_country = comboACountry.SelectedItem.ToString();
                flight.Direction = comboDirection.SelectedItem.ToString();
                flight.Type = comboType.SelectedItem.ToString();
                flight.Price = float.Parse(txtPrice.Text);
                flight.No_seat = Int32.Parse(txtNoSeat.Text);
                flightDAO.insertFlight(flight);
                KeyValuePair<int, String> selectedPair_airplane = (KeyValuePair<int, String>)comboAirplane.SelectedItem;
                int airplane_id = selectedPair_airplane.Key;
                flightDAO.insertOwnerFlight(flight, airplane_id);
                MessageBox.Show("Add successfully");
                clearDataFlight();
                updateDatagridFlight();

            }
            else
            {
                MessageBox.Show("duplicated id");
            }
        }

        private void btnFRemove_Click(object sender, EventArgs e)
        {
            if (IsInt(txtFlightId) == false)
            {
                MessageBox.Show("Id is not an integer");
                txtFlightId.Focus();
                return;
            }

            if (IsEmpty(txt_dep_time))
            {
                MessageBox.Show("Text is empty");
                txt_dep_time.Focus();
                return;
            }

            if (IsEmpty(txt_arr_time))
            {
                MessageBox.Show("Text is empty");
                txt_arr_time.Focus();
                return;
            }

            if (IsEmpty(txt_dep_date))
            {
                MessageBox.Show("Text is empty");
                txt_dep_date.Focus();
                return;
            }

            if (IsEmpty(txt_arr_date))
            {
                MessageBox.Show("Text is empty");
                txt_arr_date.Focus();
                return;
            }

            if (IsFloat(txtPrice) == false)
            {
                MessageBox.Show("price is not an float");
                txtPrice.Focus();
                return;
            }

            if (IsInt(txtNoSeat) == false)
            {
                MessageBox.Show("No Seat is not an integer");
                txtNoSeat.Focus();
                return;
            }

            int id = Int32.Parse(txtFlightId.Text);
            KeyValuePair<int, String> selectedPair_airplane = (KeyValuePair<int, String>)comboAirplane.SelectedItem;
            int airplane_id = selectedPair_airplane.Key;
            if (flightDAO.isExistedFlightForDelete(id,airplane_id))
            {
                Flight flight = new Flight();
                flight.Id = id;
                flight.Depart_time = txt_dep_time.Text;
                flight.Arrival_time = txt_arr_time.Text;
                flight.Depart_date = txt_dep_date.Text;
                flight.Arrival_date = txt_arr_date.Text;
                flight.Depart_country = comboDCountry.SelectedItem.ToString();
                flight.Arrival_country = comboACountry.SelectedItem.ToString();
                flight.Direction = comboDirection.SelectedItem.ToString();
                flight.Type = comboType.SelectedItem.ToString();
                flight.Price = float.Parse(txtPrice.Text);
                flight.No_seat = Int32.Parse(txtNoSeat.Text);
               
                flightDAO.deleteOwnerFlight(flight, airplane_id);
                flightDAO.deleteFlight(id);
                MessageBox.Show("Delete successfully");
                clearDataFlight();
                updateDatagridFlight();

            }
            else
            {
                MessageBox.Show("flight is not existed");
            }
        }

        private void dataGridFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // click out side table data
                return;

            txtFlightId.Text = dataGridFlight.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_dep_time.Text = dataGridFlight.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_dep_date.Text = dataGridFlight.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_arr_time.Text = dataGridFlight.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_arr_date.Text = dataGridFlight.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboDCountry.SelectedItem = dataGridFlight.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboACountry.SelectedItem = dataGridFlight.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboDirection.SelectedItem = dataGridFlight.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboType.SelectedItem = dataGridFlight.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtPrice.Text = dataGridFlight.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtNoSeat.Text = dataGridFlight.Rows[e.RowIndex].Cells[10].Value.ToString();
            comboAirplane.SelectedItem = dataGridFlight.Rows[e.RowIndex].Cells[11].Value.ToString();

        }

        private void dataGridInbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // click out side table data
                return;

            txt_id_mess.Text = dataGridInbox.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        public void clearDataInbox()
        {
            txt_id_mess.Text = "";
           
        }

        private void btnRemoveMess_Click(object sender, EventArgs e)
        {
            if (IsInt(txt_id_mess) == false)
            {
                MessageBox.Show("Id is not an integer");
                txt_id_mess.Focus();
                return;
            }


            int id = Int32.Parse(txt_id_mess.Text);

            if(isExistedInbox(id))
            {
                inboxDAO.deleteInbox(id);
                MessageBox.Show("Delete successfully");
                clearDataInbox();
                updateDatagridInbox();
            }
            else
            {
                MessageBox.Show("inbox is not existed");
            }
        }

        private void btnAsyn_Click(object sender, EventArgs e)
        {
            updateDatagridBooking();
        }
    }
}
