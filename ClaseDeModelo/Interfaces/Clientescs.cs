using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClaseDeModelo.Interfaces.Clientescs;

namespace ClaseDeModelo.Interfaces
{
    internal class Clientescs
    {

        /// <summary>
        /// Represents the concrete model of a person.
        /// </summary>
        /// <seealso cref="ModelClase.Interface.IPersona" />
        public class Person 
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Person"/> class.
            /// </summary>
            public Person()
            {
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Person"/> class.
            /// </summary>
            /// <param name="name">The name.</param>
            /// <param name="lastName">The last name.</param>
            /// <param name="country">The country.</param>
            public Person(string name, string lastName, string country)
            {
                this.Name = name;
                this.LastName = lastName;
                this.Country = country;
            }

            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the last name.
            /// </summary>
            /// <value>
            /// The last name.
            /// </value>
            public string LastName { get; set; }

            /// <summary>
            /// Gets or sets the country.
            /// </summary>
            /// <value>
            /// The country.
            /// </value>
            public string Country { get; set; }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// A <see cref="System.String" /> that represents this instance.
            /// </returns>
            public override string ToString()
            {
                return this.Name + " " + this.LastName + " " + this.Country;
            }

        }
    }
}
