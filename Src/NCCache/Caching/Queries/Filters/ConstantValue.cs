// Copyright (c) 2015 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.Collections;

namespace Alachisoft.NCache.Caching.Queries.Filters
{
    public class ConstantValue : IGenerator, IComparable
    {
        protected object constant;

        protected ConstantValue() { }
        protected ConstantValue(object con)
        {
            constant = con;
        }

        public override string ToString()
        {
            return constant.ToString();
        }
        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (obj is ConstantValue)
            {
                ConstantValue other = (ConstantValue)obj;
                return ((IComparable)constant).CompareTo((IComparable)other.constant);
            }
            return -1;
        }

        #endregion

        #region IGenerator Members

        public object Evaluate()
        {
            return constant;
        }

        public object Evaluate(string paramName, IDictionary values)
        {
            return constant;
        }

        #endregion
    }
}
