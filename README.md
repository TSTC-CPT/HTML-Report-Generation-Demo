![HTML Logo](https://github.com/dwkuehne/HTML-Report-Generation-Demo/blob/master/HTML-Logo.png "HTML Logo") 
# HTML Report Generation Demo
Demonstration of HTML and CSS reporting in a C# application. 
Example code for use by students. 

### Project Introduction
The purpose of this code is to demonstrate creating an HTML file that can be used to display reports, receipts, and other types of similar output in a highly portable light weight manner. This code uses StringBuilder with the .Append() and .AppendLine() methods.
```csharp
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
```

![Form](https://github.com/dwkuehne/HTML-Report-Generation-Demo/blob/master/form.png "Main Form")
![Report](https://github.com/dwkuehne/HTML-Report-Generation-Demo/blob/master/report.png "HTML Report")
![Source](https://github.com/dwkuehne/HTML-Report-Generation-Demo/blob/master/source.png "HTML Source")

This is not an exhaustive demonstration of HTML or CSS nor is it a complete solution for any project.
---David Kuehne, CPT Instructor, January 2021

### Development Environment

- Langauge: C#
- Development Environment: Visual Studio 2019 Community Edition
- Target Environment: Windows 10
- Target Audience: Students

### Contact
```
David Kuehne
dwkuehne@tstc.edu
Texas State Technical College
```

### <a href="https://github.com/dwkuehne/HTML-Report-Generation-Demo/blob/master/LICENSE" target="_blank">License</a>
dwkuehne/HTML-Report-Generation-Demo is licensed under the GNU General Public License v3.0

Permissions of this strong copyleft license are conditioned on making available complete source code of licensed works and modifications, which include larger works using a licensed work, under the same license. Copyright and license notices must be preserved. Contributors provide an express grant of patent rights.
