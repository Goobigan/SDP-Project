using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiSys
{
    internal class Utility
    {
        public static ComboBox loadMakes(ComboBox cboMakes)
        {
            cboMakes.Items.Clear();
            DataSet ds = Driver.getMakes();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboMakes.Items.Add(ds.Tables[0].Rows[i][0]);
            }
            return cboMakes;

        }

        public static ComboBox loadModels(ComboBox cboModels, String make)
        {
            cboModels.Items.Clear();
            DataSet ds = Driver.getModels(make);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboModels.Items.Add(ds.Tables[0].Rows[i][0]);
            }
            return cboModels;

        }

        public static void formatDriversGrid(DataGridView dg)
        {
            dg.Columns["DriverID"].Width = 30;
            dg.Columns["DriverID"].DefaultCellStyle.Format = "000";
            dg.Columns["DriverID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns["Forename"].Width = 70;
            dg.Columns["Forename"].DefaultCellStyle.Format = "000";
            dg.Columns["Forename"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns["Surname"].Width = 70;
            dg.Columns["Surname"].DefaultCellStyle.Format = "000";
            dg.Columns["Surname"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
