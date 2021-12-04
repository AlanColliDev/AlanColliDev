using AdminSAP.Utils;
using AdminSAP.Views.Loading;
using SAP_LIB.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSAP.Views.BitacorasVw
{
    public partial class frmProductos : Form
    {
        bool fgFirstAccess = true;
        int countRegisters = 0;
        int registroActual = 0;
        int countSelect = 10;
        bool fgMinus = false;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarInformacion()
        {
            try
            {
                DataTable tbl = new DataTable();
                DataTable tableCount = new DataTable();

                //textBox1.Text = query;
                //string path = "C:\\admin.txt";

                //using (StreamWriter writer = new StreamWriter(path, true))
                //{
                //    writer.WriteLine(string.Format($"select SAP: {query} \n"));
                //    writer.Close();
                //}
                if (!DBConn.OpenConnection(DBConn.ConectionDB.Primaria))
                {
                    MessageBox.Show("No hay conexión con el servidor");
                
                }
                else
                {
                    DBConn.CloseConnection();
                }
                String fgFilter = txtCriterioBusqueda.Text.Trim();
                string query = string.Empty;
                if (!string.IsNullOrEmpty(fgFilter))
                    query = $"SELECT {parseStringBD("zAdi_SyncItemsId")}, {parseStringBD("zAdi_DateSend")}, {parseStringBD("zAdi_DateRegister")}, {parseStringBD("zAdi_ItemCode")}, {parseStringBD("zAdi_ItemName")}, {parseStringBD("zAdi_Action")} FROM  {parseStringBD("zAdi_SyncItems")} WHERE CONTAINS(({parseStringBD("zAdi_ItemCode")}, {parseStringBD("zAdi_ItemName")}),'%{fgFilter}%') ORDER BY {parseStringBD("zAdi_DateSend")} DESC, {parseStringBD("zAdi_DateRegister")} DESC LIMIT {countSelect} OFFSET {(registroActual)}";
                else
                    query = $"SELECT {parseStringBD("zAdi_SyncItemsId")}, {parseStringBD("zAdi_DateSend")}, {parseStringBD("zAdi_DateRegister")}, {parseStringBD("zAdi_ItemCode")}, {parseStringBD("zAdi_ItemName")}, {parseStringBD("zAdi_Action")} FROM  {parseStringBD("zAdi_SyncItems")} ORDER BY {parseStringBD("zAdi_DateSend")} DESC, {parseStringBD("zAdi_DateRegister")} DESC LIMIT {countSelect} OFFSET {registroActual}";
                //txtCriterioBusqueda.Text = query;
                mdLoading.ExecuteWork(this,"Procesando...", () =>{
                //string query = $"SELECT {parseStringBD("zAdi_SyncItemsId")}, {parseStringBD("zAdi_DateSend")}, {parseStringBD("zAdi_DateRegister")}, {parseStringBD("zAdi_ItemCode")}, {parseStringBD("zAdi_ItemName")}, {parseStringBD("zAdi_Action")} FROM  {parseStringBD("zAdi_SyncItems")} ORDER BY {parseStringBD("zAdi_DateSend")} DESC, {parseStringBD("zAdi_DateRegister")} DESC";
                    tbl = DBConn.ExecQuery(query);

                    string queryCOunt = string.IsNullOrEmpty(fgFilter) ? $"SELECT COUNT(*) FROM {parseStringBD("zAdi_SyncItems")}": $"SELECT COUNT(*) FROM {parseStringBD("zAdi_SyncItems")} WHERE CONTAINS(({parseStringBD("zAdi_ItemCode")}, {parseStringBD("zAdi_ItemName")}),'%{fgFilter}%')";
                    tableCount = DBConn.ExecQuery(queryCOunt);
                });
                if(fgFirstAccess)
                    registroActual += int.Parse(cmbRegistros.SelectedValue.ToString());

                countRegisters = tableCount != null && tableCount.Rows.Count > 0 ? int.Parse(tableCount.Rows[0].ItemArray[0].ToString()) : 0;

                lblRegistroActual.Text = $"{(registroActual > countRegisters ? countRegisters : registroActual)} de {countRegisters}";

                btnMas.Enabled = !(registroActual >= countRegisters || (registroActual + int.Parse(cmbRegistros.SelectedValue.ToString())) > countRegisters );
                btnMenos.Enabled = !(registroActual <= int.Parse(cmbRegistros.SelectedValue.ToString()));


                if(tbl != null && tbl.Rows.Count > 0)
                {
                    //MessageBox.Show("hola");
                    grvConsulta.Columns.Clear();
                    grvConsulta.DataSource = tbl;

                    grvConsulta.Columns["zAdi_SyncItemsId"].Visible = false;
                    grvConsulta.SetFormatColumn("zAdi_DateSend", "Sincronizado", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_DateRegister", "Registro", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_ItemCode", "Código", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_ItemName", "Descripción", DataGridViewAutoSizeColumnMode.Fill);
                    grvConsulta.SetFormatColumn("zAdi_Action", "Acción", DataGridViewAutoSizeColumnMode.DisplayedCells);

                    grvConsulta.ScrollBars = ScrollBars.Both;
                }
                else
                {
                    MessageBox.Show("No se encontraron elementos");
                    grvConsulta.ClearGridView();
                    return;
                }

                //grvConsulta.SetFormatColumn("zAdi_TpConfig", "Tipo de configuración", DataGridViewAutoSizeColumnMode.Fill);

            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        public string parseStringBD(string str)
        {
            return $"\"{str}\"";
        }

        private void frmBitacoras_Load(object sender, EventArgs e)
        {
            this.ConfigureDesign();
            loadComboBox();
            cargarInformacion();
            fgFirstAccess = false;
        }

        private void loadComboBox()
        {
            try
            {
                List<comboBoxItems> lsItems = new List<comboBoxItems>()
                {
                    new comboBoxItems { valueString = "10", viewString = "10"},
                    new comboBoxItems {valueString = "20", viewString = "20" },
                    new comboBoxItems {valueString = "50", viewString = "50" },
                    new comboBoxItems {valueString = "100", viewString = "100" }
                };

                Controles.LoadDataToCombobox(cmbRegistros, lsItems, "valueString", "viewString");
            }
            catch(Exception ex)
            {

            }
        }

        private void cmbRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!fgFirstAccess)
                {
                    if(cmbRegistros.SelectedIndex != -1)
                    {
                        //registroActual += int.Parse(cmbRegistros.SelectedValue.ToString());
                        if (int.Parse(cmbRegistros.SelectedValue.ToString()) != countSelect)
                        {
                            countSelect = int.Parse(cmbRegistros.SelectedValue.ToString());
                            registroActual = 0;
                            fgFirstAccess = true;
                            cargarInformacion();
                            fgFirstAccess = false;
                        }
                        //else
                        //    cargarInformacion();
                    }
                }
            }
            catch(Exception ex) { }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            try
            {
                registroActual += int.Parse(cmbRegistros.SelectedValue.ToString());
                cargarInformacion();
            }
            catch (Exception ex) { }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            registroActual -= int.Parse(cmbRegistros.SelectedValue.ToString());
            if(registroActual < 0)
                registroActual = 0;

            cargarInformacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbRegistros.SelectedIndex = 0;
            countSelect = 10;
            registroActual = 0;
            fgFirstAccess = true;
            cargarInformacion();
            fgFirstAccess = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbRegistros.SelectedIndex = 0;
            countSelect = 10;
            registroActual = 0;
            txtCriterioBusqueda.Clear();
            fgFirstAccess = true;
            cargarInformacion();
            fgFirstAccess = false;
            txtCriterioBusqueda.Select();
        }

        private void chkFeInicioSinc_CheckedChanged(object sender, EventArgs e)
        {
            chkFeFinSinc.Enabled = chkFeInicioSinc.Checked;
        }

        private void chkFeFinSinc_CheckedChanged(object sender, EventArgs e)
        {
            dtFeFinSinc.Enabled = chkFeFinSinc.Checked;
        }
    }

    class comboBoxItems
    {
        public string viewString { get; set; }
        public string valueString { get; set; }
    }
}
