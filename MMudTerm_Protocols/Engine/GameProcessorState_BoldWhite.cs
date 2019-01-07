﻿using MMudObjects;

namespace MMudTerm_Protocols.Engine
{
    internal class GameProcessorState_BoldWhite : GameProcessorState
    {
        internal override GameProcessorState HandleTermCmd(WorkerState_InGame workerState, TermCmd cmd)
        {
            return this.GetNextState(workerState, cmd);
        }

    }
}