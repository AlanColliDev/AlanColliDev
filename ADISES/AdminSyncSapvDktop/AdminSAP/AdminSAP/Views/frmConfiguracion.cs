using AdminSAP.Utils;
using AdminSAP.Views.Loading;
using SAP_LIB.Controllers;
using SAP_LIB.Models;
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

namespace AdminSAP.Views
{
    public partial class frmConfiguracion : Form
    {
        List<Prueba> lsPrueba = new List<Prueba>();
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            this.ConfigureDesign();
            //Controles.ConfigurarDataGridView(grvConsulta);
            //grvConsulta.ClearGridView();

            AddEventKeyPressNumeric(new MetroFramework.Controls.MetroTextBox[] { txtClientes, txtLeads, txtPedidos, txtProducto, txtReglaPrecio, txtTiempo, txtTipoCambio });
            loadInformation_v2();
        }

        private void loadInformation()
        {
            try
            {
                DataTable table = new DataTable();
                string query = string.Empty;
                mdLoading.ExecuteWork(this, "Procesando...", () =>
                {
                    //"SELECT t.TEXT AS \"Name\", p.PRODUCTID as \"Product ID\", p.CATEGORY as \"Category\"" +
                    //" FROM \"" + SCHEMA + "\".\"" + PRODUCTS_TABLE + "\" p INNER JOIN \"" + SCHEMA + "\".\"" + TEXT_TABLE + "\" t ON t.TEXTID = p.NAMEID " + "INNER JOIN \"" + SCHEMA + "\".\"" + PARTNER_TABLE + "\" bp ON p.\"SUPPLIERID.PARTNERID\" = bp.PARTNERID";

                    query = "SELECT \"zAdi_SyncConfigId\", \"zAdi_TpConfig\", \"zAdi_ActRegister\", \"zAdi_Interval\", \"zAdi_CountRegister\" FROM \"" + DBConn.zAdi_SyncConfig + "\"";
                    //query = "SELECT * FROM \"" + DBConn.DB + "\".\"" + DBConn.zAdi_SyncConfig + "\"";

                    table = DBConn.ExecQuery(query);
                });
                txtQuery.Text = query;
                if (table != null && table.Rows.Count > 0)
                {
                    grvConsulta.Columns.Clear();
                    grvConsulta.DataSource = table;

                    grvConsulta.Columns["zAdi_SyncConfigId"].Visible = false;
                    grvConsulta.SetFormatColumn("zAdi_TpConfig", "Tipo de configuración", DataGridViewAutoSizeColumnMode.Fill);
                    grvConsulta.SetFormatColumn("zAdi_ActRegister", "Registro actual", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_Interval", "Intérvalo en minutos", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_CountRegister", "Cantidad a recorrer", DataGridViewAutoSizeColumnMode.DisplayedCells);

                    Controles.AddFormatColumnDataGridView(grvConsulta, new string[] { "zAdi_ActRegister", "zAdi_Interval", "zAdi_CountRegister" }, FormatosColumnas.Numerico);
                    grvConsulta.ReadOnly = false;
                    grvConsulta.Columns.OfType<DataGridViewColumn>().ToList().ForEach(column => column.ReadOnly = (column.Name != "zAdi_Interval" && column.Name != "zAdi_CountRegister"));
                }
                else
                {
                    grvConsulta.ClearGridView();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadInformation_v2()
        {
            string path = "C:\\loadinfo.txt";
            try
            {
                DataTable table = new DataTable();
                string query = string.Empty;
                mdLoading.ExecuteWork(this, "Procesando...", () =>
                {

                    query = "SELECT * FROM \"" + DBConn.zAdi_SyncConfig + "\"";
                    table = DBConn.ExecQuery(query, DBConn.ConectionDB.Bitacoras);
                });
                txtQuery.Text = query;
                if (table != null && table.Rows != null && table.Rows.Count > 0)
                {
                    string zAdi_Interval = table.Rows[0]["zAdi_Interval"] != null && !string.IsNullOrEmpty(table.Rows[0]["zAdi_Interval"].ToString()) ? table.Rows[0]["zAdi_Interval"].ToString() : "";

   
                    bool zAdi_FlagSeconds = table.Rows[0]["zAdi_FlagSeconds"] != null && !string.IsNullOrEmpty(table.Rows[0]["zAdi_FlagSeconds"].ToString()) ? Convert.ToBoolean( int.Parse(table.Rows[0]["zAdi_FlagSeconds"].ToString().Trim())) : false;

                    
                    txtTiempo.Text = zAdi_Interval;
                    if (zAdi_FlagSeconds)
                    {
                        rdtSeconds.Checked = true;
                        rdtMinutos.Checked = false;
                    }
                    else
                    {
                        rdtMinutos.Checked = true;
                        rdtSeconds.Checked = false;
                    }

                    bool fgProductos = false;
                    bool fgLead = false;
                    bool fgClientes = false;
                    bool fgReglasPrecio = false;
                    bool fgPedidos = false;
                    bool fgTipoCambio = false;

                    foreach (DataRow row in table.Rows)
                    {
                        string zAdi_TpConfig = row["zAdi_TpConfig"] != null && !string.IsNullOrEmpty(row["zAdi_TpConfig"].ToString()) ? row["zAdi_TpConfig"].ToString() : "";
                        string zAdi_CountRegister = row["zAdi_CountRegister"] != null && !string.IsNullOrEmpty(row["zAdi_CountRegister"].ToString()) ? row["zAdi_CountRegister"].ToString() : "";

                        bool zAdi_FlagSync = row["zAdi_FlagSync"] != null && !string.IsNullOrEmpty(row["zAdi_FlagSync"].ToString()) ? Convert.ToBoolean(int.Parse(row["zAdi_FlagSync"].ToString().Trim())) : false;

                        switch (zAdi_TpConfig)
                        {
                            case "Productos":
                                txtProducto.Text = zAdi_CountRegister;
                                fgProductos = zAdi_FlagSync;
                                break;
                            case "Leads":
                                txtLeads.Text = zAdi_CountRegister;
                                fgLead = zAdi_FlagSync;
                                break;
                            case "Clientes":
                                txtClientes.Text = zAdi_CountRegister;
                                fgClientes = zAdi_FlagSync;
                                break;
                            case "Reglas de precio":
                                txtReglaPrecio.Text = zAdi_CountRegister;
                                fgReglasPrecio = zAdi_FlagSync;
                                break;
                            case "Pedidos":
                                txtPedidos.Text = zAdi_CountRegister;
                                fgPedidos = zAdi_FlagSync;
                                break;
                            case "Tipo de cambio":
                                txtTipoCambio.Text = zAdi_CountRegister;
                                fgTipoCambio = zAdi_FlagSync;
                                break;
                            default:

                                break;
                        }

                    }
                    chkSincronizar.Checked = (fgClientes && fgLead && fgPedidos && fgProductos && fgReglasPrecio && fgTipoCambio);

                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine(string.Format($"fgClientes: {fgClientes}, fgLead: {fgLead}, fgProductos: {fgProductos}, fgReglasPrecio: {fgReglasPrecio}, fgReglasPrecio: {fgReglasPrecio}, fgPedidos: {fgPedidos} \n"));
                        writer.Close();
                    }
                    chkProductos.Checked = fgProductos;
                    chkLeads.Checked = fgLead;
                    chkClientes.Checked = fgClientes;
                    chkReglasPrecio.Checked = fgReglasPrecio;
                    chkPedidos.Checked = fgPedidos;
                    chkTipoCambio.Checked = fgTipoCambio;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void Save()
        //{
        //    try
        //    {
        //        if (grvConsulta.Rows != null && grvConsulta.Rows.Count > 0)
        //        {
        //            DataTable table = (DataTable)grvConsulta.DataSource;
        //            if (table.Rows != null && table.Rows.Count > 0)
        //            {
        //                int registerUpdate = 0;
        //                mdLoading.ExecuteWork(this, "Guardando...", () =>
        //                {
        //                    for (int index = 0; index < table.Rows.Count; index++)
        //                    {
        //                        string query = $"UPDATE {Utils.Utils.parseStringBD(DBConn.DB)}.{Utils.Utils.parseStringBD(DBConn.zAdi_SyncConfig)} SET {Utils.Utils.parseStringBD(zAdi_SyncConfig.zAdi_Interval)} = '{Convert.ToInt32(table.Rows[index][zAdi_SyncConfig.zAdi_Interval].ToString())}', {Utils.Utils.parseStringBD(zAdi_SyncConfig.zAdi_CountRegister)} = '{Convert.ToInt32(table.Rows[index][zAdi_SyncConfig.zAdi_CountRegister].ToString())}' WHERE {Utils.Utils.parseStringBD(zAdi_SyncConfig.zAdi_SyncConfigId)} = {table.Rows[index][zAdi_SyncConfig.zAdi_SyncConfigId].ToString()}";
        //                        if (DBConn.ExecQueryUpdate(query))
        //                            registerUpdate++;
        //                    }
        //                });

        //                MessageBox.Show($"{registerUpdate} {(registerUpdate > 1 ? "registros actualizados " : "registro actualizado ")}con éxito.");
        //                loadInformation();
        //            }
        //        }
        //    }
        //    catch(Exception ex) { }
        //}

        private void Save_v2()
        {
            try
            {
                if (validateField())
                {
                    string interval = txtTiempo.Text.Trim();
                    bool fgSegundos = rdtSeconds.Checked;

                    string rngoProductos = txtProducto.Text.Trim();
                    bool fgProductos = chkProductos.Checked;

                    string rngoReglasPrecio = txtReglaPrecio.Text.Trim();
                    bool fgReglasPrecio = chkReglasPrecio.Checked;

                    string rngoLeads = txtLeads.Text.Trim();
                    bool fgLeads = chkLeads.Checked;

                    string rngoClientes = txtClientes.Text.Trim();
                    bool fgClientes = chkClientes.Checked;

                    string rngoPedidos = txtPedidos.Text.Trim();
                    bool fgPedidos = chkPedidos.Checked;

                    string rngoTipoCambio = txtTipoCambio.Text.Trim();
                    bool fgTipoCambio = chkTipoCambio.Checked;


                    string update = string.Empty;
                    update += $"UPDATE {Utils.Utils.parseStringBD("zAdi_SyncConfig")} SET {Utils.Utils.parseStringBD("zAdi_Interval")} = {interval}, {Utils.Utils.parseStringBD("zAdi_CountRegister")} = {rngoProductos}, {Utils.Utils.parseStringBD("zAdi_FlagSeconds")} = {(fgSegundos? "TRUE": "FALSE")}, {Utils.Utils.parseStringBD("zAdi_FlagSync")} = {(fgProductos ? "TRUE": "FALSE")} WHERE {Utils.Utils.parseStringBD("zAdi_TpConfig")} = 'Productos'";
                    DBConn.ExecQueryUpdate(update, DBConn.ConectionDB.Bitacoras);

                    update = string.Empty;
                    update += $"UPDATE {Utils.Utils.parseStringBD("zAdi_SyncConfig")} SET {Utils.Utils.parseStringBD("zAdi_Interval")} = {interval}, {Utils.Utils.parseStringBD("zAdi_CountRegister")} = {rngoReglasPrecio}, {Utils.Utils.parseStringBD("zAdi_FlagSeconds")} = {(fgSegundos? "TRUE": "FALSE")}, {Utils.Utils.parseStringBD("zAdi_FlagSync")} = {(fgReglasPrecio ? "TRUE": "FALSE")} WHERE {Utils.Utils.parseStringBD("zAdi_TpConfig")} = 'Reglas de precio'";
                    DBConn.ExecQueryUpdate(update, DBConn.ConectionDB.Bitacoras);

                    update = string.Empty;
                    update += $"UPDATE {Utils.Utils.parseStringBD("zAdi_SyncConfig")} SET {Utils.Utils.parseStringBD("zAdi_Interval")} = {interval}, {Utils.Utils.parseStringBD("zAdi_CountRegister")} = {rngoLeads}, {Utils.Utils.parseStringBD("zAdi_FlagSeconds")} = {(fgSegundos? "TRUE": "FALSE")}, {Utils.Utils.parseStringBD("zAdi_FlagSync")} = {(fgLeads ? "TRUE": "FALSE")} WHERE {Utils.Utils.parseStringBD("zAdi_TpConfig")} = 'Leads'";
                    DBConn.ExecQueryUpdate(update, DBConn.ConectionDB.Bitacoras);

                    update = string.Empty;
                    update += $"UPDATE {Utils.Utils.parseStringBD("zAdi_SyncConfig")} SET {Utils.Utils.parseStringBD("zAdi_Interval")} = {interval}, {Utils.Utils.parseStringBD("zAdi_CountRegister")} = {rngoClientes}, {Utils.Utils.parseStringBD("zAdi_FlagSeconds")} = {(fgSegundos? "TRUE": "FALSE")}, {Utils.Utils.parseStringBD("zAdi_FlagSync")} = {(fgClientes ? "TRUE": "FALSE")} WHERE {Utils.Utils.parseStringBD("zAdi_TpConfig")} = 'Clientes'";
                    DBConn.ExecQueryUpdate(update, DBConn.ConectionDB.Bitacoras);

                    update = string.Empty;
                    update += $"UPDATE {Utils.Utils.parseStringBD("zAdi_SyncConfig")} SET {Utils.Utils.parseStringBD("zAdi_Interval")} = {interval}, {Utils.Utils.parseStringBD("zAdi_CountRegister")} = {rngoPedidos}, {Utils.Utils.parseStringBD("zAdi_FlagSeconds")} = {(fgSegundos? "TRUE": "FALSE")}, {Utils.Utils.parseStringBD("zAdi_FlagSync")} = {(fgPedidos ? "TRUE": "FALSE")} WHERE {Utils.Utils.parseStringBD("zAdi_TpConfig")} = 'Pedidos'";
                    DBConn.ExecQueryUpdate(update, DBConn.ConectionDB.Bitacoras);

                    update = string.Empty;
                    update += $"UPDATE {Utils.Utils.parseStringBD("zAdi_SyncConfig")} SET {Utils.Utils.parseStringBD("zAdi_Interval")} = {interval}, {Utils.Utils.parseStringBD("zAdi_CountRegister")} = {rngoTipoCambio}, {Utils.Utils.parseStringBD("zAdi_FlagSeconds")} = {(fgSegundos ? "TRUE" : "FALSE")}, {Utils.Utils.parseStringBD("zAdi_FlagSync")} = {(fgTipoCambio ? "TRUE" : "FALSE")} WHERE {Utils.Utils.parseStringBD("zAdi_TpConfig")} = 'Tipo de cambio'";
                    DBConn.ExecQueryUpdate(update, DBConn.ConectionDB.Bitacoras);

                    MessageBox.Show("Operación realizada con éxito.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private bool validateField()
        {

            if(!rdtMinutos.Checked && !rdtSeconds.Checked)
            {
                MessageBox.Show("Seleccione un intérvalo válido (Minutos o Segundos).");
                return false;
            }

            string msg = string.Empty;

            if (string.IsNullOrEmpty(txtTiempo.Text.Trim()))
                msg += "Tiempo de descanso";

            if (string.IsNullOrEmpty(txtProducto.Text.Trim()))
                msg += $"{(!string.IsNullOrEmpty(msg) ? ",": "")} Rango de registro de productos";

            if (string.IsNullOrEmpty(txtReglaPrecio.Text.Trim()))
                msg += $"{(!string.IsNullOrEmpty(msg) ? "," : "")} Rango de registro de Reglas de precio";

            if (string.IsNullOrEmpty(txtLeads.Text.Trim()))
                msg += $"{(!string.IsNullOrEmpty(msg) ? "," : "")} Rango de registro de Leads";

            if (string.IsNullOrEmpty(txtClientes.Text.Trim()))
                msg += $"{(!string.IsNullOrEmpty(msg) ? "," : "")} Rango de registro de Clientes";

            if (string.IsNullOrEmpty(txtPedidos.Text.Trim()))
                msg += $"{(!string.IsNullOrEmpty(msg) ? "," : "")} Rango de registro de Pedidos";

            if (string.IsNullOrEmpty(txtTipoCambio.Text.Trim()))
                msg += $"{(!string.IsNullOrEmpty(msg) ? "," : "")} Rango de registro de Tipo de cambio";

            if (!string.IsNullOrEmpty(msg))
            {
                string message = msg.Any(x => x == ',') ? $"Los campos {msg} son requeridos." : $"El campo {msg} es requerido.";

                MessageBox.Show(message);
                return false;
            }

            return true;

        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvConsulta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if(e.ColumnIndex != -1)
                {
                    if (grvConsulta.Columns[e.ColumnIndex].Name == "zAdi_Interval" || grvConsulta.Columns[e.ColumnIndex].Name == "zAdi_CountRegister" && e.RowIndex == -1) Controles.AddIconInColumnHeader(e, Properties.Resources.edit_24);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //try
            //{
            //    if (e.ColumnIndex != -1)
            //    {
            //        if ((grvConsulta.Columns[e.ColumnIndex].Name == "Importe" || grvConsulta.Columns[e.ColumnIndex].Name == "IVAFlete") && e.RowIndex == -1)
            //        {
            //            Controles.AddIconInColumnHeader(e, Properties.Resources.edit_24);
            //        }
            //    }

            //}
            //catch
            //{
            //    e.Handled = false;
            //}
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Save_v2();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private bool validateSync()
        {
            return (chkClientes.Checked && chkLeads.Checked && chkPedidos.Checked && chkProductos.Checked && chkReglasPrecio.Checked && chkTipoCambio.Checked);
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chkSincronizar.Checked = validateSync();
            }
            catch { }
        }

        private void chkSincronizar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkSincronizar_Click(object sender, EventArgs e)
        {
            chkClientes.Checked = chkSincronizar.Checked;
            chkLeads.Checked = chkSincronizar.Checked;
            chkPedidos.Checked = chkSincronizar.Checked;
            chkProductos.Checked = chkSincronizar.Checked;
            chkReglasPrecio.Checked = chkSincronizar.Checked;
            chkTipoCambio.Checked = chkSincronizar.Checked;
        }

        public void AddEventKeyPressNumeric(MetroFramework.Controls.MetroTextBox[] controls)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                controls[x].KeyPress += KeyPressNumeric;
            }
        }

        public  void KeyPressNumeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }

    public class Prueba
    {
        public string Modulo { get; set; }
        public string Registros { get; set; }
        public bool fgSync { get; set; }
    }
}
