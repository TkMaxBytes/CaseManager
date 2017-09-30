using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caseman
{

    namespace busmodel
    {
        class Contact
        {
            private string mstrTitle = null;
            private string mstrFirstName = null;
            private string mstrLastName = null;
            private string mstrPreferredName = null;
            private UInt16  mintUtcOffset = 0;


            public Contact()
            {

            }

            /// <summary>
            /// The Title of the the contact.
            /// </summary>
            public string Title
            {
                get { return mstrTitle; }
                set
                {
                    string strMess = null;
                    int anyVal;
                    if (int.TryParse(value, out anyVal))
                    {
                        strMess = "A title can't be a number!";
                        throw new ArgumentException(strMess);
                    }
                    mstrTitle = value;
                }
            }

            /// <summary>
            /// 
            /// </summary>
            public string FirstName
            {
                get { return mstrFirstName; }
                set
                {
                    string strMess = null;
                    int anyVal;
                    if (int.TryParse(value, out anyVal))
                    {
                        strMess = "A FirstName can't be a number!";
                        throw new ArgumentException(strMess);
                    }
                    if (string.IsNullOrEmpty(value))
                    {
                        mstrFirstName = value.Trim();
                    }
                    else {
                        mstrFirstName = value;
                    }
                    
                }
            }


        }
    }
    
}
