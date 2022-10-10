using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net6WinFormsRelatorio
{
  public partial class frmRelatorioCliente : Form
  {
    public frmRelatorioCliente()
    {
      InitializeComponent();
      reportViewer1.LocalReport.ReportEmbeddedResource = "Net6WinFormsRelatorio.relCliente.rdlc";
      reportViewer1.RefreshReport();
    }
  }
}
