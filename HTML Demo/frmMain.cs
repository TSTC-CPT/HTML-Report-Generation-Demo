///<summary>
///The purpose of this code is to demonstrate creating an HTML file that can be used to display reports,
///receipts, and other types of similar output in a highly portable light weight manner. 
///
/// This is not an exhaustive demonstration of HTML or CSS nor is it a complete solution for any project.
/// ---David Kuehne, CPT Instructor, January 2021
///</summary>

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HTML_Demo
{
    public partial class frmMain : Form
    {
        private List<Person> people = new List<Person>(); // Global list of Person objects

        public frmMain()
        {
            InitializeComponent();
        }

        //Person class that has the first name, last name, and age properties.
        public class Person
        {
            public string strFirstName { get; set; }
            public string strLastName { get; set; }
            public int intAge { get; set; }

            public Person(string strFirst, string strLast, int intPersonAge)
            {
                strFirstName = strFirst;
                strLastName = strLast;
                intAge = intPersonAge;
            }
        }

        /// <summary>
        /// Using StringBuilder to keep up with all the lines of text produced.
        /// AppendLine() automatically places a line break at the end.
        /// Append() attaches to the last part of the previous string.
        /// https://www.tutorialsteacher.com/csharp/csharp-stringbuilder
        /// </summary>
        /// <param name="title">This is used for the browser tab and the H1 tag.</param>
        /// <returns>Will return all necessary code to produce a local HTML file.</returns>
        private StringBuilder GenerateReport(string title)
        {
            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();

            // CSS is a way to style the HTML page. Each HTML tag can be customized.
            // In this example, the H1 and TD tags are customized.
            // Refer to this website for examples: https://www.w3schools.com/Css/css_syntax.asp

            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-align:center; font-weight: bold; text-align: center;}");
            css.AppendLine("h1 {color: blue;}");
            css.AppendLine("</style>");

            // HTML is used to format the layout of a webpage. This will be the frame
            // we use to place our data in. CSS is used to style the page to look a
            // certain way.

            // The <HTML> and </HTML> tags are the start and end of a webpage.
            // The <HEAD> and </HEAD> tags gives information about the webpage
            // such as the title and if there is any CSS styles being used.
            // The text between the <TITLE> and </TITLE> tags are used by the
            // browser to display the name of the page.
            // <BODY> and </BODY> is where the data of the page is stored
            // <H1> and </H1> is the largest font size for headings. These
            // can be from H1 to H6. H6 is the smallest font. https://www.w3schools.com/tags/tag_hn.asp

            html.AppendLine("<html>");
            html.AppendLine($"<head>{css}<title>{title}</title></head>");
            html.AppendLine("<body>");

            html.AppendLine($"<h1>{title}</h1>");

            // Create table of data
            // <TABLE> and </TABLE> is the start and end of a table of rows and data.
            // <TR> and </TR> is one row of data. They contain <TD> and </TD> tags.
            // <TD> and </TD> represents the data inside of the table in a particular row.
            // https://www.w3schools.com/tags/tag_table.asp

            // I used an <HR /> tag which is a "horizontal rule" as table data.
            // You can "span" it across multiple columns of data.

            html.AppendLine("<table>");
            html.AppendLine("<tr><td>First Name</td><td>Last Name</td><td>Age</td></tr>");
            html.AppendLine("<tr><td colspan=3><hr /></td></tr>");
            foreach (Person person in people)
            {
                html.Append("<tr>");
                html.Append($"<td>{person.strFirstName}</td>");
                html.Append($"<td>{person.strLastName}</td>");
                html.Append($"<td>{person.intAge}</td>");
                html.Append("</tr>");
                html.AppendLine("<tr><td colspan=4><hr /></td></tr>");
            }
            html.AppendLine("</table>");
            html.AppendLine("</body></html>");

            return html; // The returned value has all the HTML and CSS code to represent a webpage
        }

        /// <summary>
        /// I separated the code that produced the HTML and CSS from the action
        /// of creating the file on the hard drive then opening it. This could
        /// be included in one function, but went with the separation of duties.
        /// </summary>
        /// <param name="html">This method expects all the code from the
        /// StringBuilder we used earlier.</param>
        private void PrintReport(StringBuilder html)
        {
            // Write (and overwrite) to the hard drive using the same filename of "Report.html"
            try
            {
                // A "using" statement will automatically close a file after opening it.
                // It never hurts to include a file.Close() once you are done with a file.
                using (StreamWriter writer = new StreamWriter("Report.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(@"Report.html"); //Open the report in the default web browser
            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If you want a unique filename you could use a date and time with part of a name
            DateTime today = DateTime.Now;
            using (StreamWriter writer = new StreamWriter($"{today.ToString("yyyy-MM-dd-HHmmss")} - Report.html"))
            {
                writer.WriteLine(html);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate that data was entered
            // Prompt user of the error and give
            // focus to the textbox with the error
            if (tbxTitle.Text == String.Empty)
            {
                MessageBox.Show("Please enter a title for the report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxTitle.Focus();
                return;
            }
            if (tbxFirstName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxFirstName.Focus();
                return;
            }
            if (tbxLastName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxLastName.Focus();
                return;
            }
            if (!int.TryParse(tbxAge.Text, out _)) // The underscore represents discarding the data
            {
                MessageBox.Show("Age must be a whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAge.Focus();
                tbxAge.SelectAll();
                return;
            }

            // Add the TextBox data into a new instance of Person and add the object to the list
            people.Add(new Person(tbxFirstName.Text, tbxLastName.Text, int.Parse(tbxAge.Text)));
            lbxPeople.Items.Add($"{tbxFirstName.Text} {tbxLastName.Text} - {tbxAge.Text} years old");

            // Clear all TextBoxes except the title
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxAge.Clear();
            tbxFirstName.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (lbxPeople.Items.Count == 0)
                MessageBox.Show("Nothing to report.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                PrintReport(GenerateReport(tbxTitle.Text));
        }

        //Reset TextBox controls, ListBox control, and List container
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxPeople.Items.Clear();
            people.Clear();
            tbxTitle.Clear();
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxAge.Clear();
            tbxFirstName.Focus();
            tbxTitle.Focus();
        }
    }
}