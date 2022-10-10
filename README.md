# WinFormsRelatorio

para que o projeto funcione corretamente será necessário ter instalado a extensão:
1 - Vá em Extensions/Manage Extensions - procure por rdlc (Microsoft RDLC Report Designer 2022), faça a instalação dele.
2 - Depois em Manage packagtes for Solution  - instale o pacote ReportViewerCore.WinForms
3-  após isso basta arrastar o compontente para o form, será criado um repotViewer1, adicione manualmentea linha abaixo
    em InitializeComponent():
    //frmRelatorioCliente
     this.Controls.Add(this.reportViewer1);
4 - importante também clicar com botão direito do mouse sobre relCliente.rdlc para alterar a propriedade:
    Build Action = Embedded resource
    
5 - outra observação importante é configurar nosso controle reportViewer1, vamos fazer isso no construtor do form.
      reportViewer1.LocalReport.ReportEmbeddedResource = "WinFormsRelatorio.relCliente.rdlc";
      reportViewer1.RefreshReport();

    
PRONTO, com isso teremos funcionando nosso relatorio.    
