using SAP_LIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSAP.Utils
{
    public static class Extensions
    {
        #region DataGridView

        public static void ClearGridView(this MetroFramework.Controls.MetroGrid grvConsulta)
        {
            try
            {
                Controles.EmptyDataGrid(grvConsulta);
            }
            catch (Exception ex)
            {
                grvConsulta.Columns.Clear();
                grvConsulta.DataSource = null;
            }
            finally
            {
                //Nadaa se genero un error en los dos bloques anteriores

            }
        }

        public static void ClearGridView(this DataGridView grvConsulta)
        {
            try
            {
                Controles.EmptyDataGrid(grvConsulta);
            }
            catch (Exception ex)
            {
                grvConsulta.Columns.Clear();
                grvConsulta.DataSource = null;
            }
            finally
            {
                //Nadaa se genero un error en los dos bloques anteriores

            }
        }

        public static void SetFormatColumn(this DataGridView grvConsulta, string columnName, string HeaderText, DataGridViewAutoSizeColumnMode AutoSizeMode, DataGridViewContentAlignment ContentAlignment = DataGridViewContentAlignment.MiddleLeft, int Width = -1)
        {
            try
            {
                grvConsulta.Columns[columnName].HeaderText = HeaderText;
                grvConsulta.Columns[columnName].AutoSizeMode = AutoSizeMode;
                if (grvConsulta.Columns[columnName] is DataGridViewTextBoxColumn)
                    grvConsulta.Columns[columnName].DefaultCellStyle.Alignment = ContentAlignment;
                if (Width != -1)
                {
                    grvConsulta.Columns[columnName].Width = Width;
                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Date

        public static DateTime ToLocalTimeMexico(this DateTime t)
        {
            TimeZoneInfo tm = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time (Mexico)");
            DateTime Time = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, tm);

            return Time;
        }

        public static int DaysDif(this DateTime t, DateTime compare)
        {
            try
            {
                int day = (t - compare).Days;

                return day;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        #endregion

        public static void TruncateDouble(this DataGridViewColumn column, int numDecimales, FormatosColumnas formatoCol)
        {
            switch (formatoCol)
            {
                case FormatosColumnas.Moneda:
                    column.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-us");
                    column.DefaultCellStyle.Format = $"C{numDecimales}";
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    break;

                case FormatosColumnas.Numerico:
                    column.DefaultCellStyle.Format = $"N{numDecimales}";
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    break;

                case FormatosColumnas.Porcentaje:
                    column.DefaultCellStyle.Format = $"p{numDecimales}";
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    break;
            }
        }

        public static void ConfigureDesign(this Form frm)
        {
            try
            {
            Controles.ConfigurarDisenio(new Control[] { frm });
            }
            catch(Exception ex) { }
        }

        
    }
}
