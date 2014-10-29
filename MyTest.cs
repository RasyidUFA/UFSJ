using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;

namespace UFSJ
{

#if DEBUG
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MyTestClass
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void GeneratePages()
        {
            MessageBox.Show(String.Join(",", PageParse("1,18")));
        }

        private int[] PageParse(string p)
        {
            var i = new List<int>();
            var strs = p.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (var m in strs)
                {
                    if (m.Contains("-") || m.Contains("_") || m.Contains("..."))
                    {
                        var a = m.Split(new[] { "-", "_", "..." }, StringSplitOptions.RemoveEmptyEntries);
                        if (a.Length != 2)
                            throw new InvalidOperationException("Invalid Format : Invalid length");

                        int a1 = int.Parse(a[0]);
                        int a2 = int.Parse(a[1]);
                        if (a1 > a2)
                        { var t = a1; a1 = a2; a2 = t; }
                        for (int r = a1; r <= a2; r++)
                        {
                            if (!i.Contains(r))
                            {
                                i.Add(r);
                            }
                        }
                    }
                    else
                    {
                        if (!i.Contains(int.Parse(m)))
                        {
                            i.Add(int.Parse(m));
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Invalid Format");
            }

            return i.ToArray();

        }
    } 
#endif
}
