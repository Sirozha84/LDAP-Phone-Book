using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace LDAP_Phone_Book
{
    class Print
    {
        static List<Contact> book;
        static int stringNum = 0;
        static int nPage = 0;
        static Graphics g;

        //Шрифты и ручки
        static Font F10 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);
        static Font F20 = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel);
        static StringFormat InCenter = new StringFormat { Alignment = StringAlignment.Center };
        static StringFormat InLeft = new StringFormat { Alignment = StringAlignment.Near };
        static Pen Slim = new Pen(Color.Black, 1);

        public static void Start(List<Contact> list)
        {
            book = list;
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PrintDocument doc = new PrintDocument();
                    doc.PrintPage += new PrintPageEventHandler(Page);
                    doc.PrinterSettings = dialog.PrinterSettings;
                    doc.PrinterSettings.DefaultPageSettings.Landscape = false; //Горизонтальный, если не для ротопринта
                    doc.Print();
                }
                catch { }
            }
        }

        static void Page(object sender, PrintPageEventArgs e)
        {
            g = e.Graphics;
            int x;
            int y = 40;
            int w;
            int h;
            if (nPage++ == 0)
            {
                h = 25;
                g.DrawString("Телефонная книга (" + DateTime.Now.ToString("dd.MM.yyyy)"), F20, Brushes.Black, new Rectangle(40, y, 750, h), InCenter);
                y += h + 20;
            }
            x = 40;
            w = 250; DrawCell("ФИО", x, y, w, InCenter); x += w;
            w = 200; DrawCell("Подразделение", x, y, w, InCenter); x += w;
            w = 100; DrawCell("Внут.", x, y, w, InCenter); x += w;
            w = 100; DrawCell("Внешний", x, y, w, InCenter); x += w;
            w = 100; DrawCell("Мобильный", x, y, w, InCenter);
            y += 15;
            for (int i = stringNum; i < book.Count; i++)
            {
                x = 40;
                w = 250; DrawCell(book[i].name, x, y, w, InLeft); x += w;
                w = 200; DrawCell(book[i].dep, x, y, w, InLeft); x += w;
                w = 100; DrawCell(book[i].phoneW, x, y, w, InLeft); x += w;
                w = 100; DrawCell(book[i].phoneG, x, y, w, InLeft); x += w;
                w = 100; DrawCell(book[i].phoneM, x, y, w, InLeft); y += 15;
                stringNum++;
                //Не влезло на страницу
                if (y > 1120 & stringNum < book.Count)
                {
                    e.HasMorePages = true; return;
                }
            }
        }

        static void DrawCell(string str, int x, int y, int width, StringFormat format)
        {
            int height = 15;
            g.DrawString(str, F10, Brushes.Black, new Rectangle(x + 2, y + 2, width, height), format);
            g.DrawRectangle(Slim, new Rectangle(x, y, width, height));
        }
    }
}
