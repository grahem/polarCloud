using Microsoft.AspNetCore.Mvc;
using Site.ServiceModels;
using System;

namespace Site.Services
{
    
    public class RegisterS3ContactService : IRegisterContactService
    {

        ContactHttpResponse IRegisterContactService.Register(Contact contact)
        {
            //call S3
            contact.Id = Guid.NewGuid().ToString();
            return new ContactHttpResponse() { Contact = contact, Date = DateTime.Now, Status = System.Net.HttpStatusCode.Created };
        }

    }

    
        
}

    
