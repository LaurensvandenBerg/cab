﻿using System;

namespace ConsoleAppBase
{
    public class Help
    {
        private Command _command;
        private HelpBuilder _builder;
        private string _full;
        private string _version;
        private string _usage;

        private void Build()
        {
            if (_builder == null)
            {
                _builder = new HelpBuilder(_command, this);
                _builder.BuildHelp();
            }
        }

        /// <summary>
        /// Help object used to get help information on the given Command.
        /// </summary>
        /// <param name="command">Command from which the help information is derived.</param>
        public Help(Command command)
        {
            _command = command;
        }

        /// <summary>
        /// Helptext containing information on all subcommands, arguments and options.
        /// </summary>
        public string Full
        {
            get { Build(); return _full; }
            set => _full = value;
        }

        /// <summary>
        /// Version of the console application.
        /// </summary>
        public string Version
        {
            get { Build(); return _version; }
            set => _version = value;
        }

        /// <summary>
        /// Shows the usage of the current Command.
        /// </summary>
        public string Usage
        {
            get { Build(); return _usage; }
            set => _usage = value;
        }
    }
}
