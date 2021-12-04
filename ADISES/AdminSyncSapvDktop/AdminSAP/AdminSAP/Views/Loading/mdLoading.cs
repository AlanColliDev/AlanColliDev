using SAP_LIB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSAP.Views.Loading
{
    public partial class mdLoading : Form
    {
        public Action worker { get; set; }
        Task task;
        loading load;
        public mdLoading(Action worker)
        {
            InitializeComponent();
            this.worker = worker;
        }

        public interface loading
        {
            ResponseObjectVM load(ResponseObjectVM response, int type);
        }

        public void textoTitulo(string text)
        {
            if (!string.IsNullOrEmpty(text))
                lblMensaje.Text = text;
        }

        CancellationTokenSource cancelSurce = new CancellationTokenSource();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CancellationToken token = cancelSurce.Token;

            try
            {
                task = Task.Factory.StartNew(()=> {
                    try
                    {
                        worker();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"Error back {ex.ToString()}");
                    }
                }, token).ContinueWith(x =>
                 this.cancel());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error back {ex.ToString()}");
                this.cancel();
            }
        }

        public void cancel()
        {
            cancelSurce.Cancel();
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {

                        Close();
                    });
                }
                else this.Close();

                //cacelado..........
            }
            catch (Exception e)
            {
                Close();
            }

        }

        //fix show mdLoading
        private static mdLoading loadingStatic = null;

        public static mdLoading ExecuteWork(IWin32Window frmContext, String titleWork, Action doWorkAction)
        {
            if (mdLoading.loadingStatic == null)
            {
                mdLoading.loadingStatic = new mdLoading(doWorkAction);
            }
            else
            {
                mdLoading.loadingStatic.cancel();
                mdLoading.loadingStatic = new mdLoading(doWorkAction);
            }

            mdLoading.loadingStatic.ShowInTaskbar = false;
            mdLoading.loadingStatic.textoTitulo(titleWork);
            mdLoading.loadingStatic.ShowDialog(frmContext);

            return mdLoading.loadingStatic;
        }

        public static mdLoading ExecuteWork(Form frmContext, String titleWork, Action doWorkAction)
        {
            if (mdLoading.loadingStatic == null)
            {
                mdLoading.loadingStatic = new mdLoading(doWorkAction);
            }
            else
            {
                mdLoading.loadingStatic.cancel();
                mdLoading.loadingStatic = new mdLoading(doWorkAction);
            }

            mdLoading.loadingStatic.ShowInTaskbar = false;
            mdLoading.loadingStatic.textoTitulo(titleWork);
            mdLoading.loadingStatic.ShowDialog(frmContext);

            return mdLoading.loadingStatic;
        }
        public static void CancelInstanceLoading()
        {
            try
            {
                if (mdLoading.loadingStatic != null)
                {
                    mdLoading.loadingStatic.cancel();
                }
            }
            catch (Exception ex)
            {
                mdLoading.loadingStatic = null;
            }
        }
    }
}
