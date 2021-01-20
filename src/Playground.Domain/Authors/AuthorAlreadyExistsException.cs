using System;
using Volo.Abp;

namespace Playground.Authors
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(PlaygroundDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
