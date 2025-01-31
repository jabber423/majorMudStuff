﻿namespace MMudTerm_Protocols.AnsiProtocolCmds
{
    class AnsiCursorFwdCmd : TermCmd
    {
        int cols = -1;
        public AnsiCursorFwdCmd(byte[] vals)
        {
            cols = customAtoi(vals);
        }

        public override void DoCommand(ITermProtocolCmds terminal)
        {
#if DEBUG_2
            Debug.WriteLine("ENTER: " +
                    System.Reflection.MethodBase.GetCurrentMethod().Name,
                    this.GetType().Namespace);
#endif
            (terminal as IAnsiProtocolCmds).DoCursorFwd(cols);
        }
    }
}
