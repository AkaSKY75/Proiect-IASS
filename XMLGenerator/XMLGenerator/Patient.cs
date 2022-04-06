using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public record Patient(int patientId, Identifier identifier, bool active, HumanName name, ContactPoint telecom, string gender, DateTime birthdate, string deceased, Address address, CodeableConcept martialStatus, int multipleBirth, Attachement photo, Contact contact, Communication communication, string generalPractitioner, string managingOrganization, Link link);
}
