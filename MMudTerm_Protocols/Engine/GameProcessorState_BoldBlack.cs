﻿using MMudObjects;
namespace MMudTerm_Protocols.Engine
{
    internal class GameProcessorState_BoldBlack : GameProcessorState
    {
        internal override GameProcessorState HandleTermCmd(WorkerState_InGame workerState, TermCmd cmd)
        {
            return this.GetNextState(workerState, cmd);
        }

        internal override void HandleTermStringDataCmd(WorkerState_InGame workerState, TermStringDataCmd stringCmd)
        {
            Log.Tag(this.Tag, ">" + stringCmd.GetValue() + "<");
        }
    }
}