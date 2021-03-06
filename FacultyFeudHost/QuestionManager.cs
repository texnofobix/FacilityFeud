﻿/*
    This file is part of Faculty Feud.

    Faculty Feud is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Faculty Feud is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Faculty Feud.  If not, see <http://www.gnu.org/licenses/>.
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacultyFeudHost
{
    struct Question
    {
        public string q; //question
        public int n; //question number
        public List<string> a; //answer
		public List<int> p; //answer points
    };
    class QuestionManager
    {
        public static List<Question> questions = null; //a list of question objects
    }
}
