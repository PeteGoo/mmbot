﻿using System.ComponentModel.Composition;
using System.Threading.Tasks;
using ScriptCs.Contracts;

namespace MMBot.ScriptCS
{
    [PartNotDiscoverable]
    public class MMBot2ScriptPackInternal : IScriptPack<Robot>
    {
        private Robot _robot;

        public MMBot2ScriptPackInternal(Robot robot)
        {
            _robot = robot;
        }

        public void Initialize(IScriptPackSession session)
        {

        }

        public IScriptPackContext GetContext()
        {
            return _robot;
        }

        public void Terminate()
        {

        }

        Robot IScriptPack<Robot>.Context
        {
            get { return _robot; }
            set { _robot = value; }
        }
    }
}