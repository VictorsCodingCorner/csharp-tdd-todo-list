﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    public class TodoTaskObj
    {
        private string contentText;
        //True if complete false if incomplete
        private bool complete;
        private int id;

        public TodoTaskObj(string contentText, bool Complete)
        {
            this.contentText = contentText;
            this.complete = Complete;
            this.id.GetHashCode();
        }

        public TodoTaskObj(string contentText)
        {
            this.contentText = contentText;
            this.complete = false;
            this.id.GetHashCode();
        }

        public string ContentText
        {
            get { return contentText; }

        }

        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }

        public void ChangeStatus()
        {
            if (complete)
            {
                complete = false;
            }
            else
            {
                complete = true;
            }
        }

        public int Id { get { return id; } }
    }
}

