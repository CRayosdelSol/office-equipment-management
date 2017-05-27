namespace EquipmentLibrary
{
    /// <summary>
    /// Aggeregates all information about an Equipment Manufacturer
    /// </summary>
    public class Manufacturer
    {
        Address mnfctrrAdd;
        string email_add;
        string contact_number;
        string name;

        /// <summary>
        /// Creates an instance of the manufacturer class
        /// </summary>
        /// <param name="name">The name of the manufacturing companys</param>
        /// <param name="add">Address of the company</param>
        /// <param name="email">Service/Helpdesk e-mail address</param>
        /// <param name="contact">Hotline/Service number</param>
        public Manufacturer(string name, Address add, string email, string contact)
        {
            this.name = name;
            mnfctrrAdd = add;
            email_add = email;
            contact_number = contact;
        }
    }
}
