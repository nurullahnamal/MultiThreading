using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class FakeDataCreator
    {
        public static IEnumerable<MailObject> GetSmtpMails(int number)
        {
            Bogus.Faker<MailObject> faker
                = new Bogus.Faker<MailObject>()
                .RuleFor(i => i.To, y => y.Internet.Email())
                .RuleFor(i => i.ProviderType, y => MailProviderType.Smtp);

            return faker.Generate(number);
        }
    }
}
