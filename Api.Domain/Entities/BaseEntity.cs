using Dapper.Contrib.Extensions;
using System;

namespace Api.Domain.Entities
{
    public abstract class BaseEntity
    {
        [ExplicitKey]
        public Guid Id { get; set; }

        private DateTime? _dataAtualizacao;
        public DateTime? DataAtualizacao
        {
            get { return _dataAtualizacao; }
            set { _dataAtualizacao = (value == null ? DateTime.UtcNow : value); }
        }
    }
}
