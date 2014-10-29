using System;
namespace UFSJ.Sharp
{
    class BatchM
    {
        internal BatchM(bool echo, int cols, int lines)
        {
            EchoSW(echo);
            WriteLn(string.Format("mode con cols={0} lines={1}", cols, lines));
        }

        internal void WriteLn(string str) { Result += str + "\r\n"; }

        internal void Task(string command, params object[] Parameters)
        {
            var a = "";
            foreach (var item in Parameters) { a += item; }
            Result += command + a + "\r\n";
        }
        internal void Confirmation(string confirm)
        {
            Label("_set"); Sets("_ok", ""); Sets("_ok", confirm + " [Y^|N] -^> ", true);
            Ifs("_ok", "y", "Start"); Ifs("_ok", "Y", "Start"); Ifs("_ok", "n", "Exit"); Ifs("_ok", "N", "Exit");
            Goto("Main");
        }

        internal void Sets(string str, string val, bool b = false) { WriteLn("set " + (b ? "/p " + str : str) + "=" + val); }
        internal void IfED(string p) { WriteLn("if exist \"" + p + "\" == \"" + p + "\" del \"" + p + "\""); }
        internal void Ifs(string var, string val, string label) { WriteLn("if \"%" + var + "%\" == \"" + val + "\" GOTO:" + label); }
        internal void Goto(string p) { WriteLn("Goto:" + p); }
        internal void Label(string str) { WriteLn(":" + str); }
        internal void Pause() { WriteLn("pause"); }
        internal void Title(string title) { WriteLn("title " + title); }
        internal void Comment(string str) { WriteLn("::" + str); }


        internal void Echo(string str) { WriteLn("echo " + str); }
        internal void EchoSW(bool echo) { WriteLn("@echo " + (echo ? "on" : "off")); }
        internal void Clear() { WriteLn("clr"); }

        internal string Result;

    }
}
