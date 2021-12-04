using MetroFramework.Controls;
using SAP_LIB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSAP.Utils
{
    public class Controles
    {
        public static Controles getInstance() => new Controles();

        #region Configuracion Label
        public static Font Label_font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        public static int Height_Controls = 30;
        public static void ConfigureLabel(Control[] controls)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                ((Label)controls[x]).Font = new System.Drawing.Font("Segoe UI", 12F/*, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel*/);
                ((Label)controls[x]).TextAlign = ContentAlignment.MiddleLeft;
                //((Label)controls[x]).Padding = new Padding(0, 6, 0, 3);
            }
        }
        #endregion

        #region ConfigurarDisenioGeneral

        public static void ConfigurarDisenio(Control[] controls, params Control[] arrayIgnoreControls)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                if (controls[x] is Panel)
                {
                   
                    switch (controls[x].Name)
                    {
                        case "pnlToolbar":
                            Panel header = controls[x] as Panel;
                            header.BackColor = Utils.getInstance().BackColorToolBar;
                            //header.ForeColor = colorNegro;
                            break;

                        case "pnlMenuVertical":
                            Panel menu = controls[x] as Panel;
                            menu.BackColor = Utils.getInstance().BackColorToolBar;
                            break;

                        case "pnlHeader":

                            break;
                    }
                    //return;
                    continue;
                }

                if (controls[x] is Form)
                {
                    ((Form)controls[x]).BackColor = Utils.getInstance().backColorForm;
                    ConfigurarDisenioControles(((Form)controls[x]), arrayIgnoreControls);
                    continue;
                }
            }
        }

        private static void ConfigurarDisenioControles(Form frm, Control[] arrayIgnoreControls)
        {
            try
            {
                if (frm.Controls != null && frm.Controls.Count > 0)
                {
                    var metroComboBox = GetAll(frm, typeof(MetroComboBox));
                    if (metroComboBox != null && metroComboBox.Count() > 0)
                    {
                        foreach (var item in arrayIgnoreControls)
                        {
                            metroComboBox = metroComboBox.ToList().Where(x => x.Name != item.Name).ToArray();
                        }
                        ConfigurarCombo(metroComboBox);
                    }

                    var Labels = GetAll(frm, typeof(Label));
                    if (Labels != null && Labels.Count() > 0)
                    {
                        Labels = Labels.ToList().Where(x => x.Name.Trim() != "lblFormTitulo" && x.Name.Trim() != "lblAyuda" && x.Name.Trim() != "lblCerrar").ToArray();
                        if (Labels != null && Labels.Count() > 0)
                            ConfigureLabel(Labels);
                    }

                    var CheckBoxs = GetAll(frm, typeof(CheckBox));
                    if (CheckBoxs != null && CheckBoxs.Count() > 0)
                    {
                        ConfigureCheckbox(CheckBoxs);
                    }

                    var radioButtons = GetAll(frm, typeof(RadioButton));
                    if (radioButtons != null && radioButtons.Count() > 0)
                    {
                        ConfigureRadioButton(radioButtons);
                    }

                    var dateTimePicker = GetAll(frm, typeof(DateTimePicker));
                    if (dateTimePicker != null && dateTimePicker.Count() > 0)
                    {
                        foreach (var item in arrayIgnoreControls)
                        {
                            dateTimePicker = dateTimePicker.ToList().Where(x => x.Name != item.Name).ToArray();
                        }
                        ConfigurarDateTimePicker(dateTimePicker);
                    }

                    var metroTextBox = GetAll(frm, typeof(MetroTextBox));
                    if (metroTextBox != null && metroTextBox.Count() > 0)
                    {
                        foreach (var item in arrayIgnoreControls)
                        {
                            metroTextBox = metroTextBox.ToList().Where(x => x.Name != item.Name).ToArray();
                        }
                        ConfigureTextBox(metroTextBox);
                    }

                    var metroGrid = GetAll(frm, typeof(DataGridView));
                    if (metroGrid != null && metroGrid.Count() > 0)
                    {
                        for (int i = 0; i < metroGrid.Count(); i++)
                        {
                            ConfigurarDataGridView((metroGrid[i] as DataGridView));
                            (metroGrid[i] as DataGridView).ClearGridView();
                        }
                    }

                    var paneles = GetAll(frm, typeof(Panel));
                    if(paneles != null && paneles.Count() > 0)
                    {
                        for(int index = 0; index < paneles.Count(); index++)
                        {
                            if (paneles[index].Name == "pnlToolbar" || paneles[index].Name == "pnlMenuVertical")
                            {
                                Panel header = paneles[index] as Panel;
                                header.BackColor = Utils.getInstance().BackColorToolBar;
                            }
                        }
                    }

                    var groupBox = GetAll(frm, typeof(GroupBox));
                    if(groupBox != null && groupBox.Count() > 0)
                    {
                        ConfigureGroupBox(groupBox);
                    }
                }
            }
            catch (Exception ex)
            {
                //Wops un error...
            }
        }

        public static Control[] GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type).ToArray();
        }

        #endregion

        #region DataGridView
        public static void EmptyDataGrid(DataGridView gridView)
        {
            gridView.Columns.Clear();
            DataTable empty = new DataTable();
            empty.Columns.Add("No se encontraron elementos.", typeof(string));
            gridView.DataSource = empty;
            gridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.ScrollBars = ScrollBars.None;
        }

        public static void EmptyDataGrid(DataGridView gridView, String textEmpty)
        {
            gridView.Columns.Clear();
            DataTable empty = new DataTable();
            empty.Columns.Add(textEmpty, typeof(string));
            gridView.DataSource = empty;
            gridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.ScrollBars = ScrollBars.None;
        }

        public static void AutoSizeButtonsDataGrid(DataGridView gridView)
        {
            gridView.MultiSelect = false;
            gridView.ScrollBars = ScrollBars.None;
            foreach (DataGridViewImageColumn button in gridView.Columns.OfType<DataGridViewImageColumn>())
            {
                button.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                button.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public static void LoadingDataGrid(DataGridView gridView)
        {
            gridView.Columns.Clear();
            DataTable empty = new DataTable();
            empty.Columns.Add("Cargando...", typeof(string));
            gridView.DataSource = empty;
            gridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.ScrollBars = ScrollBars.None;
        }

        public static void ConfigurarDataGridView(DataGridView gridview)
        {
            //gridview.BackgroundColor = Color.FromArgb(47, 43, 44);
            gridview.BackgroundColor = Color.White;

            /*gridview.RowHeadersDefaultCellStyle.SelectionBackColor = Color.LightGray;
            gridview.RowHeadersDefaultCellStyle.BackColor = Color.Violet; //No sirve por ahora*/



            /*-------------------Columns Header configuration-------------*/

            gridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridview.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            gridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridview.ColumnHeadersHeight = 35;


            /*-------------------Rows configuration-------------*/
            //gridview.RowsDefaultCellStyle.BackColor = Color.FromArgb(47, 43, 44);
            gridview.RowsDefaultCellStyle.BackColor = Color.LightGray;
            gridview.RowsDefaultCellStyle.Font = new Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gridview.RowsDefaultCellStyle.ForeColor = Color.Black;
            gridview.RowsDefaultCellStyle.SelectionBackColor = Color.Gray; //Selection color
            //gridview.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(72, 68, 69); //Selection color
            gridview.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            gridview.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            /*-------------------Alternative Rows configuration-------------*/
            gridview.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            //gridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(53, 49, 50);
            gridview.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            //Disable options for add elements for users
            gridview.AllowUserToAddRows = false;
            gridview.AllowUserToDeleteRows = false;
            gridview.AllowUserToResizeColumns = false;
            gridview.AllowUserToResizeRows = false;
            gridview.ReadOnly = true;

            /*-------------------RowsHeaders configuration-------------*/
            gridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridview.RowTemplate.Height = 30;

            gridview.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview.BorderStyle = BorderStyle.FixedSingle;
            gridview.CellBorderStyle = DataGridViewCellBorderStyle.None;

            gridview.RowHeadersVisible = false;

            gridview.EnableHeadersVisualStyles = false;
            gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //gridview.SelectionColor = Color.LightGray;
            gridview.MultiSelect = false;
        }

        public static void AddIconInColumnHeader(DataGridViewCellPaintingEventArgs e, Image image)
        {
            Rectangle r32 = new Rectangle(e.CellBounds.Left + e.CellBounds.Width - 24, 10, 24, 24);
            Rectangle r96 = new Rectangle(0, 0, 30, 30);
            e.PaintBackground(e.CellBounds, true);
            e.PaintContent(e.CellBounds);

            e.Graphics.DrawImage(image, r32, r96, GraphicsUnit.Pixel);
            e.Handled = true;
        }

        public static void AddFormatColumnDataGridView(DataGridView gridView, string[] Columnas, FormatosColumnas formatoColumna)
        {

            for (int x = 0; x < Columnas.Length; x++)
            {
                switch (formatoColumna)
                {
                    case FormatosColumnas.Moneda:
                        gridView.Columns[Columnas[x]].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-us");
                        gridView.Columns[Columnas[x]].DefaultCellStyle.Format = "C2";
                        gridView.Columns[Columnas[x]].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;

                    case FormatosColumnas.Numerico:
                        gridView.Columns[Columnas[x]].DefaultCellStyle.Format = "N2";
                        gridView.Columns[Columnas[x]].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;

                    case FormatosColumnas.Porcentaje:
                        gridView.Columns[Columnas[x]].DefaultCellStyle.Format = "0\\%";
                        gridView.Columns[Columnas[x]].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                }
            }
        }
        #endregion

        #region Combobox
        /*-------------------------------Configure View MetroCombobox-------------------------------*/
        public static void ConfigurarCombo(MetroComboBox cmb)
        {
            cmb.FontSize = MetroFramework.MetroComboBoxSize.Tall;
        }

        public static void ConfigurarCombo(Control[] controls)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                //      ((CTSkinetTextBox)controls[x]).Text

                ((MetroComboBox)controls[x]).FontSize = MetroFramework.MetroComboBoxSize.Small;
            }
        }
        /*-------------------------------Configure View Combobox-------------------------------*/
        public static void ConfigureComboBox(Control[] controls)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                ((ComboBox)controls[x]).Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            }
        }

        public static void ConfigureComboBox(Control[] controls, string nbFont)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                ((ComboBox)controls[x]).Font = new System.Drawing.Font(nbFont, 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            }
        }

        public static void ConfigureComboBox(Control[] controls, string nbFont, float fontSize)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                ((ComboBox)controls[x]).Font = new System.Drawing.Font(nbFont, (float)fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            }
        }

        public static void ConfigureComboBox(Control[] controls, string nbFont, float fontSize, bool fgBold)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                ((ComboBox)controls[x]).Font = new System.Drawing.Font(nbFont, (float)fontSize, (fgBold ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular), System.Drawing.GraphicsUnit.Pixel);
            }
        }

        /*-------------------------------Load Data To Combobox-------------------------------*/
        public static void LoadDataToComboBox(ComboBox comboBox, Object Data)
        {
            comboBox.DataSource = Data;
        }
        public static void LoadDataToComboBox(ComboBox comboBox, Object Data, String Value, String View)
        {
            comboBox.ValueMember = Value;
            comboBox.DisplayMember = View;
            comboBox.DataSource = Data;
            comboBox.SelectedIndex = 0;
        }
        public static void LoadDataToCombobox(ComboBox comboBox, Object Data, String Value, String View)
        {
            comboBox.ValueMember = Value;
            comboBox.DisplayMember = View;
            comboBox.DataSource = Data;
            comboBox.SelectedIndex = 0;
        }
        public static void LoadDataToComboBoxPercent(ComboBox comboBox, Object Data, String Value, String View)
        {
            comboBox.ValueMember = Value;
            comboBox.DisplayMember = View;
            comboBox.DataSource = Data;
            comboBox.SelectedIndex = 0;
            comboBox.FormatString = "0\\%";
        }
        #endregion

        #region CheckBox
        public static void ConfigureCheckbox(Control[] controls)
        {
            try
            {
                for (int x = 0; x < controls.Length; x++)
                {
                    ((CheckBox)controls[x]).Font = new System.Drawing.Font("Segoe UI", 12F/*, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel*/);
                    ((CheckBox)controls[x]).TextAlign = ContentAlignment.MiddleLeft;
                }
            }
            catch (Exception ex) { }
        }
        #endregion

        #region RadioButton

        public static void ConfigureRadioButton(Control[] controls)
        {
            try
            {
                for (int x = 0; x < controls.Length; x++)
                {
                    ((RadioButton)controls[x]).Font = new System.Drawing.Font("Segoe UI", 12F/*, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel*/);
                    ((RadioButton)controls[x]).TextAlign = ContentAlignment.MiddleLeft;
                }
            }
            catch (Exception ex) { }
        }

        #endregion

        #region DateTimePicker

        public static void ConfigurarDateTimePicker(Control[] controls)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                if (((DateTimePicker)controls[x]).Format != DateTimePickerFormat.Custom)
                {
                    ((DateTimePicker)controls[x]).Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);

                }
                else
                {
                    ((DateTimePicker)controls[x]).Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);

                }
            }
        }

        public static void ConfigurarDateTimePickerHora(Control[] controls)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                ((DateTimePicker)controls[x]).Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
                ((DateTimePicker)controls[x]).Format = DateTimePickerFormat.Custom;
                ((DateTimePicker)controls[x]).CustomFormat = "hh:mm tt";
            }
        }

        public static void ConfigurarDateTimePicker(DateTimePicker dtp)
        {
            dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);

        }

        #endregion

        #region TextBox

        public static void ConfigureTextBox(Control[] controls)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                //((MetroTextBox)controls[x]).CharacterCasing = CharacterCasing.Upper;
                ((MetroTextBox)controls[x]).FontSize = MetroFramework.MetroTextBoxSize.Tall;
                ((MetroTextBox)controls[x]).Height = Height_Controls;
                //((MetroTextBox)controls[x]).Size = new Size(150, Height_Controls);
            }
        }

        #endregion

        #region GroupBox

        public static void ConfigureGroupBox(Control[] controls)
        {
            for(int x = 0; x < controls.Length; x++)
            {
                ((GroupBox)controls[x]).Font = new Font("Microsoft Sans Serif", 12F);
            }
        }

        #endregion

        public static void EnableControls(System.Windows.Forms.Control[] controls, bool enable)
        {
            for (int x = 0; x < controls.Length; x++)
            {
                controls[x].Enabled = enable;
                controls[x].BackColor = (enable == true) ? System.Drawing.SystemColors.Window : System.Drawing.Color.LightGray;

                if (controls[x] is MetroTextBox)
                {
                    ((MetroTextBox)controls[x]).UseCustomBackColor = true;
                    ((MetroTextBox)controls[x]).BackColor = (enable == true) ? System.Drawing.SystemColors.Window : System.Drawing.Color.LightGray;
                } 

                if (controls[x] is MetroComboBox)
                {
                    ((MetroComboBox)controls[x]).UseCustomBackColor = true;
                    ((MetroComboBox)controls[x]).BackColor = (enable == true) ? System.Drawing.SystemColors.Window : System.Drawing.Color.LightGray;
                }

                if (controls[x] is Button)
                {
                    controls[x].BackColor = (enable == true) ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.Control;
                }

                if (controls[x] is MetroDateTime)
                {
                    ((MetroDateTime)controls[x]).UseCustomBackColor = true;
                    ((MetroDateTime)controls[x]).BackColor = (enable == true) ? System.Drawing.SystemColors.Window : System.Drawing.Color.LightGray;
                }

                //if (controls[x].GetType() == typeof(MetroTextBox))
                //{
                //    MetroTextBox control = (MetroTextBox)controls[x];
                //}else
                //{
                //    controls[x].BackColor = (enable == true) ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.Control;
                //}
            }
        }
    }
}
