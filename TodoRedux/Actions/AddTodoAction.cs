﻿using System;
using Redux;

namespace TodoRedux.Actions
{
    internal class AddTodoAction : IAction
    {
        public string Text { get; internal set; }
        public Guid Id { get; internal set; }
    }
}