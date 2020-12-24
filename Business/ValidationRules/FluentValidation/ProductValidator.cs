using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        /// <summary>
        /// Product property kuralları
        /// </summary>
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 30);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(1);//unit price 1'den büyük veya eşit olmalı olmalıdır.
            RuleFor(p => p.ProductName).Must(StartWithA);//Ürün ismi A harfi ile başlamalıdır.
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
