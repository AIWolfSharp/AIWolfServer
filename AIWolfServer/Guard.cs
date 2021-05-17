//
// Guard.cs
//
// Copyright 2016 OTSUKI Takashi
// SPDX-License-Identifier: Apache-2.0
//

using AIWolf.Lib;

namespace AIWolf.Server
{
    /// <summary>
    /// Guard class.
    /// </summary>
    public class Guard
    {
        public int Day { get; }

        public Agent Agent { get; }

        public Agent Target { get; }

        public Guard(int day, Agent agent, Agent target)
        {
            Day = day;
            Agent = agent;
            Target = target;
        }

        public override string ToString()
        {
            return Agent + " guarded " + Target + "@" + Day;
        }
    }
}