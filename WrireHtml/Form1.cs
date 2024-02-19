using System.IO;
using System.Security.AccessControl;

namespace WrireHtml
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnHtml_Click(object sender, EventArgs e)
		{
			//string content = LerArquivoHtml(@"C:\Simulator\FullFlow.html");
			string content = LerArquivoHtml(@"C:\Rascunho\CVP\engine\Web\FullFlow.html");
			AlteraHtml(@"C:\Simulator\FullFlow2.html", content);
		}

		private string LerArquivoHtml(string path)
		{
			string content = "";
			try
			{
				//string content = File.ReadAllText("C:\\Sample.txt");
				 content = File.ReadAllText(path);
				Console.WriteLine(content);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			return content;
		}
		private void AlteraHtml(string path,string htmlOriginal)
		{
			string htmlOriginal2 = htmlOriginal;
			string formattedDate = DateTime.Now.ToString("yyyy-MM-dd_hh_mm_ss");
			//C:\Rascunho\CVP\engine\Web\FullFlow.html
		//	path = $@"C:\Rascunho\CVP\engine\Web\FullFlow-{formattedDate}.html";
			path = $@"C:\Rascunho\CVP\engine\Web\FullFlow4.html";
			//path = $@"C:\Simulator\FullFlow2-{formattedDate}.html";
			//string altera = "id='lista-Amarela-01' class=' col btn-outline-warning'";
		//	string htmlOriginal2 = htmlOriginal.Replace("id='lista-Amarela-01' class=' col btn-outline-warning'", "id='lista-Amarela-01' class=' col btn-warning'");
			// htmlOriginal = "id='lista-Amarela-01' class=' col btn-outline-warning'";
			//string nova = altera.Replace("id='lista-Amarela-01' class=' col btn-outline-warning'", "id='lista-Amarela-01' class=' col btn-warning'");
		//	 htmlOriginal2 = htmlOriginal2.Replace("id='lista-Amarela-04' class=' col btn-outline-warning'", "id='lista-Amarela-04' class=' col btn-warning'");
		//	htmlOriginal2 = htmlOriginal2.Replace("id='lista-Amarela-07' class=' col btn-outline-warning'", "id='lista-Amarela-07' class=' col btn-warning'");
			//	htmlOriginal2 = htmlOriginal2.Replace("id='lista-Amarela-00' class=' col btn-outline-warning'", "id='lista-Amarela-00' class='disabled col btn-warning'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Amarela-00' class='row yellow'", "id='lista-Amarela-00' class='disabled row yellow'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-01' class=' col btn-outline-danger'", "id='lista-Vermela-01' class=' col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-02' class=' col btn-outline-danger'", "id='lista-Vermela-02' class=' col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-03' class=' col btn-outline-danger'", "id='lista-Vermela-03' class=' col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-04' class=' col btn-outline-danger'", "id='lista-Vermela-04' class=' col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-05' class=' col btn-outline-danger'", "id='lista-Vermela-05' class=' col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-06' class=' col btn-outline-danger'", "id='lista-Vermela-06' class=' col btn-danger'");

			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-07' class=' col btn-outline-danger'", "id='lista-Vermela-07' class='text-decoration-line-through col btn-danger'");

			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-08' class=' col btn-outline-danger'", "id='lista-Vermela-08' class='disabled col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-09' class=' col btn-outline-danger'", "id='lista-Vermela-09' class='disabled col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-10' class=' col btn-outline-danger'", "id='lista-Vermela-10' class='disabled col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-11' class=' col btn-outline-danger'", "id='lista-Vermela-11' class='disabled col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-12' class=' col btn-outline-danger'", "id='lista-Vermela-12' class='disabled col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-13' class=' col btn-outline-danger'", "id='lista-Vermela-13' class='disabled col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-14' class=' col btn-outline-danger'", "id='lista-Vermela-14' class='disabled col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-15' class=' col btn-outline-danger'", "id='lista-Vermela-15' class='disabled col btn-danger'");
			htmlOriginal2 = htmlOriginal2.Replace("id='lista-Vermela-16' class=' col btn-outline-danger'", "id='lista-Vermela-16' class='disabled col btn-danger'");

			try
			{
				//string content = File.ReadAllText("C:\\Sample.txt");
			    File.WriteAllText(path,htmlOriginal2);
			//	Console.WriteLine(content);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
		//	return content;

		}

	}
}
