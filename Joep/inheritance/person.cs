using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class person : ObjectWithNameAndAge  //person herite de OBJECTwithnameandage
    {
        public int wisdom { get; set; }

        public person(int age, string name, int wisdom) : base(age, name) // on apelle le constructeur de ObjectWithNameAneAge avec base
        {
            this.wisdom = wisdom;
        }

        public override void GetOlder()
        {
            base.GetOlder(); //on apelle ObjectWithNameAndAge.GetOlder()
            this.wisdom++;
        }
    }
}
