﻿using System;
using System.Collections.Generic;

namespace MYQuizClient
{
    public partial class AnswerOption
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string IsCorrect { get; set; }
        public bool IsCorrectBool
        {
            get
            {
                if (IsCorrect == null)
                {
                    return false;
                }
                return IsCorrect.ToLower() == "true";
            }
        }
    }
}