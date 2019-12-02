using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeTierMgtSystem_1701_02_17_09_19_
{
    public partial class stored_procedures : Form
    {
        List<string> par = new List<string>();
        List<string> col = new List<string>();
        List<string> dtyp = new List<string>();
        List<string> siz = new List<string>();
        int count = 0;
        String inser = "";

        public stored_procedures()
        {
            InitializeComponent();
            forhide.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            par.Add(parametername.Text);
            col.Add(columnname.Text);
            if (settings.Checked)
            {
                string dtype = datatype.SelectedItem.ToString();
                dtyp.Add(dtype);
                if (dtype == "Int")
                {
                    siz.Add("");
                }
                else
                {
                    siz.Add("(" + size.Text + ")");
                }
            }
            else
            {
                dtyp.Add("VARCHAR");
                siz.Add("(50)");
            }

            insert.Text += columnname.Text + " => @" + parametername.Text + "\n";
            columnname.Text = parametername.Text = "";
            forhide.Visible = false;
            columnname.Focus();
            autoinc.TabIndex = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // =====================  Insert Procedure < Start > =======================

            inser = "CREATE Procedure [dbo].[SP_" + procedurename.Text + "Insert]";

            int l = 0;
            if (autoinc.Checked)
            {
                inser = inser + "\n" + " @" + par[1] + " " + dtyp[1] + siz[1];
                l = 2;
            }
            else
            {
                inser = inser + "\n" + " @" + par[0] + " " + dtyp[0] + siz[0];
                l = 1;
            }


            for (int i = l; i < par.Count; i++)
            {
                inser = inser + ",\n" + " @" + par[i] + " " + dtyp[i] + siz[i];
            }
            inser = inser + "\n AS \n BEGIN \n INSERT INTO " + tablename.Text + " values ( ";
            int j = 0;
            if (autoinc.Checked)
            {
                inser += "@" + par[1];
                j = 2;
            }
            else
            {
                inser += "@" + par[0];
                j = 1;
            }

            for (int i = j; i < par.Count; i++)
            {
                inser += ", @" + par[i];
            }
            inser += ") \n END \n GO";
            insert.Text = inser;

            // =====================  Insert Procedure < End > =======================

            // =====================  Update Procedure < Start > =======================

            string updat = "CREATE Procedure [dbo].[SP_" + procedurename.Text + "Update]";
            updat = updat + "\n" + " @" + par[0] + " " + dtyp[0] + siz[0];

            for (int i = 1; i < par.Count; i++)
            {
                updat = updat + ",\n" + " @" + par[i] + " " + dtyp[i] + siz[i];
            }
            updat = updat + "\n AS \n BEGIN \n Update " + tablename.Text + " SET ";

            updat += col[1] + " = @" + par[1];

            for (int i = 2; i < par.Count; i++)
            {
                updat += ", " + col[i] + " = @" + par[i];
            }
            updat += " Where " + col[0] + " = @" + par[0] + " \n END \n GO";
            update.Text = updat;

            // =====================  Update Procedure < End > =======================

            // =====================  Delete Procedure < Start > =======================

            string delet = "CREATE Procedure [dbo].[SP_" + procedurename.Text + "Delete]"
                + "\n" + " @" + par[0] + " " + dtyp[0] + siz[0];
            delet = delet + "\n AS \n BEGIN \n Delete From " + tablename.Text + " Where " + col[0] + " = @" + par[0] + " \n END \n GO";
            delete.Text = delet;

            // =====================  Delete Procedure < End > =======================

            // =====================  Select Procedure < Start > =======================

            string selec = "CREATE Procedure [dbo].[SP_" + procedurename.Text + "Select]"
                + "\n AS \n BEGIN \n Select * From " + tablename.Text + " \n END \n GO";
            select.Text = selec;

            // =====================  Select Procedure < End > =======================

            // =====================  Search Procedure < Start > =======================

            string searc = "CREATE Procedure [dbo].[SP_" + procedurename.Text + "Search]"
                + "\n" + " @" + par[0] + " " + dtyp[0] + siz[0];
            searc = searc + "\n AS \n BEGIN \n Select * From " + tablename.Text + " Where " + col[0] + " = @" + par[0] + " \n END \n GO";
            search.Text = searc;

            // =====================  Search Procedure < Start > =======================
        }

        private void settings_CheckedChanged(object sender, EventArgs e)
        {
            if (settings.Checked)
            {
                forhide.Visible = true;
            }
            if (!settings.Checked)
            {
                forhide.Visible = false;
            }
        }

        private void sameparam_CheckedChanged(object sender, EventArgs e)
        {
            if (sameparam.Checked)
            {
                parametername.Text = columnname.Text;
            }
            if (!sameparam.Checked)
            {
                parametername.Text = "";
            }
        }

        private void columnname_TextChanged(object sender, EventArgs e)
        {
            if (sameparam.Checked)
            {
                parametername.Text = columnname.Text;
            }
        }
    }
}
