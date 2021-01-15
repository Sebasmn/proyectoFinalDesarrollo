using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Word = Microsoft.Office.Interop.Word;
using System.Web.UI.WebControls;
using System.Reflection;
using System.IO;
using System.Text;
using MySql.Data.MySqlClient;

public partial class Rectorado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        cargarDatos();
    }

    private void cargarDatos()
    {
        List<String> datos = new List<string>();
        datos.Add("Clay Aldaz");
        datos.Add("Pedrito");
        datos.Add("Maria Chavez");

        DropDownList1.DataSource = datos;
       DropDownList1.DataBind();

        List<String> dias = new List<string>();
        for (int i = 1; i <= 31; i++)
        {
            dias.Add(i.ToString());
        }

        DropDownList2.DataSource = dias;
        DropDownList2.DataBind();


        List<String> meses = new List<string>();
        meses.Add("enero");
        meses.Add("febrero");
        meses.Add("marzo");
        meses.Add("abril");
        meses.Add("mayo");
        meses.Add("junio");
        meses.Add("julio");
        meses.Add("agosto");
        meses.Add("septiembre");
        meses.Add("octubre");
        meses.Add("noviembre");
        meses.Add("diciembre");


        DropDownList3.DataSource = meses;
        DropDownList3.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        StringBuilder sb1 = new StringBuilder();
        sb1.Append(@"D:\Documentos\Pruebas\");
        StringBuilder sb2 = new StringBuilder();
        //  sb2.Append(textBox_Nombre.Text);
        sb2.Append("Uno");
        sb1.Append(sb2.ToString());
        sb1.Append(".docx");
        CreateWordDocument(@"D:\Documentos\OficiosPlantilla\plantilla.docx", sb1.ToString());
    }
    private void CreateWordDocument(object filename, object SaveAs)
    {
        Word.Application wordApp = new Word.Application();
        object missing = Missing.Value;
        Word.Document myWordDoc = null;

        if (File.Exists((string)filename))
        {
            object readOnly = false;
            object isVisible = false;
            wordApp.Visible = false;

            myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                    ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing, ref missing);
            myWordDoc.Activate();

            //find and replace
            this.FindAndReplace(wordApp, "<fecha>", TextBox1.Text);
            this.FindAndReplace(wordApp, "<nombre>", TextBox2.Text);

            /* this.FindAndReplace(wordApp, "<name>", textBox_Nombre.Text);
             this.FindAndReplace(wordApp, "<id>", textBox_Cedula.Text);
             this.FindAndReplace(wordApp, "<level>", textBox_Nivel.Text);
             this.FindAndReplace(wordApp, "<carrer>", textBox_Carrera.Text);
             this.FindAndReplace(wordApp, "<course>", comboBox_Materia.SelectedItem.ToString());
             this.FindAndReplace(wordApp, "<birthday>", dateTimePicker1.Value.ToShortDateString());
             this.FindAndReplace(wordApp, "<phone>", textBox_Celular.Text);
             this.FindAndReplace(wordApp, "<mail>", textBox_Correo.Text);
             this.FindAndReplace(wordApp, "<facultad>", facultad);*/


        }
        else
        {
            //MessageBox.Show("File not Found!");
        }

        //Save as
        myWordDoc.SaveAs(ref SaveAs, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing);

        myWordDoc.Close();
        wordApp.Quit();
          
    }
    private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
    {
        object matchCase = true;
        object matchWholeWord = true;
        object matchWildCards = false;
        object matchSoundLike = false;
        object nmatchAllforms = false;
        object forward = true;
        object format = false;
        object matchKashida = false;
        object matchDiactitics = false;
        object matchAlefHamza = false;
        object matchControl = false;
        object read_only = false;
        object visible = true;
        object replace = 2;
        object wrap = 1;

        wordApp.Selection.Find.Execute(ref ToFindText,
            ref matchCase, ref matchWholeWord,
            ref matchWildCards, ref matchSoundLike,
            ref nmatchAllforms, ref forward,
            ref wrap, ref format, ref replaceWithText,
            ref replace, ref matchKashida,
            ref matchDiactitics, ref matchAlefHamza,
            ref matchControl);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        getConexion();

    }

    private void getConexion()
    {
          MySqlConnection connection;
        string server = "localhost";
        string database = "u179925486_uta2020ds4";
        string uid = "u179925486_grupo";
        string  password = "jZ=4k1x3]";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

       connection = new MySqlConnection(connectionString);
        if (connection!=null)
        {
            MySqlCommand cmd = new MySqlCommand();
            TextBox1.Text = "CONECTADO";
        }
    }
}