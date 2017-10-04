using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace caseman
{

    namespace busmodel
    {


		namespace contacts {
			/// <summary>
			/// This is the class that holds the information for a contact.
			/// </summary>
			public class Contact {
                /// <summary>
                /// Get the logger for this class
                /// </summary>
                private static readonly ILog mobjLog = LogManager.GetLogger(typeof(Contact));

                private string mstrLastName = null;
				/// <summary>
				/// This is the preferred name of the contact
				/// </summary>
                private string mstrPreferredName = null;
				/// <summary>
				/// Negative or positive UTC offset for this contact
				/// </summary>
                private UInt16 mintUtcOffset = 0;

                /// <summary>
                /// This is the first name for this contact.
                /// </summary>
                private string mstrFirstName;
				/// <summary>
				/// This is the title of the contact and this shouldn't be a number it can only be
				/// a string.
				/// </summary>
				private string mstrTitle;

                public Contact()
                {
                    string mystring = null;
                }

                /// <summary>
                /// The title for the contact.
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
				/// This is the first name of the contact.
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
                        if (!string.IsNullOrEmpty(value))
                        {
                            mstrFirstName = value.Trim();
                        }
                        else
                        {
                            mstrFirstName = value;
                        }

                    }
                }



                /// <summary>
                /// This is the last name of the contact
                /// </summary>
                public string LastName{
                    get { return mstrLastName; }

                    set
                    {
                        string strMess = null;
                        int anyVal;
                        if (int.TryParse(value, out anyVal))
                        {
                            strMess = "A LastName can't be a number!";
                            
                            throw new ArgumentException(strMess);
                        }
                        if (string.IsNullOrEmpty(value))
                        {
                            mstrLastName = value.Trim();
                        }
                        else
                        {
                            mstrLastName = value;
                        }

                    }
                }

				/// <summary>
				/// This is the preferred name of the contact.  This could be the nickname or the
				/// first name.
				/// </summary>
				public string PreferedName{
					get { return mstrPreferredName; }

                    set
                    {
                        string strMess = null;
                        int anyVal;
                        if (int.TryParse(value, out anyVal))
                        {
                            strMess = "A PreferredName can't be a number!";
                            throw new ArgumentException(strMess);
                        }
                        if (string.IsNullOrEmpty(value))
                        {
                            mstrPreferredName = value.Trim();
                        }
                        else
                        {
                            mstrPreferredName = value;
                        }

                    }
                }





			}//end Contact

		}//end namespace contacts
    }
    
}
