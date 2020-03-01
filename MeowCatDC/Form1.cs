using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
namespace MeowCatDC
{
    public partial class Form1 : Form
    {
        public static void ms(string msg,string title)
        {
            MessageBox.Show(msg,title,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void urlbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getButton_Click(object sender, EventArgs e)
        {
            try
            {
                statusSet("Getting...");
                listBox1.Items.Clear();
                var client = new RestClient(urlbox.Text);
                var request = new RestRequest(idbox.Text);
                var response = client.Execute<List<Note>>(request, Method.GET);
                List<Note> n1 = response.Data;
                foreach (var v in n1)
                {
                    listBox1.Items.Add(v.value);
                }
                statusSet("Got");
            }
            catch(Exception ex)
            {
                statusSet("Unable to Get");
                ms("Server is sending bad data or connection between you and server couldn't been established.", "Bad Data Or Connection Error");
            }
        }

        private void ac_Click(object sender, EventArgs e)
        {
            idbox.Text = "note/test";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delButton_Click(object sender, EventArgs e)
        {
            try { listBox1.Items.RemoveAt(listBox1.SelectedIndex); statusSet("Deleted"); } catch (Exception) { statusSet("Unable to Delete"); }
        }

        private void addbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(addbox.Text);
            statusSet("Added");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            statusSet("Updating...");
            try
            {
                connectionTest();
                var newlist = new List<Note>();
                var id = 1;
                foreach (var v in listBox1.Items)
                {
                    newlist.Add(new Note() { id = id, value = v.ToString() });
                    id++;
                }
                var client = new RestClient(urlbox.Text);
                var request = new RestRequest(idbox.Text);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(newlist);
                client.Execute(request, Method.POST);
                statusSet("Updated");
            }
            catch(Exception)
            {
                statusSet("Unable to Update");
                ms("ID is wrong or connection between you and server couldn't been established.", "Bad ID Or Connection Error");
            }
        }

        private void idbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearall_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            statusSet("Cleared");
        }

        private void statuslabel_Click(object sender, EventArgs e)
        {

        }
        public void statusSet(string mess)
        {
            statuslabel.AutoSize = true;
            statuslabel.Text = "Status: " + mess;
        }
        private void connectionTest()
        {
            var client = new RestClient(urlbox.Text);
            var request = new RestRequest(idbox.Text);
            var response = client.Execute<List<Note>>(request, Method.GET);
            List<Note> n1 = response.Data;
            Console.WriteLine(n1[0].value);
        }
    }
}
