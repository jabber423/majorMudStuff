﻿namespace MMudTerm_Protocols
{
    /// <summary>
    /// Commands for basic telnet usage
    /// </summary>
    public interface ITermProtocolCmds
    {

        void DoCarrigeReturn();
        void DoNewLine();
        void DoBackSpace();

        //void AddChar(char c);
        void AddCharString(byte[] str);
    }
}
