﻿using App.Library.Data.Dtos;
using App.Library.Interfaces;
using App.Library.Interfaces.Repository;
using App.Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace App.Library.Data.DataAccess
{
    public class SellerRepository : ISellerRepository
    {
        private readonly IDatabase _database;

        public SellerRepository(IDatabase database)
        {
            _database = database;
        }

        public void Create(string firstName, string lastName, string email, int companyId)
        {
            var id = _database.Sellers.Count > 0 ? _database.Sellers.Last().Id + 1 : 0;

            var seller = new SellerModel
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                CompanyId = companyId
            };

            _database.Sellers.Add(seller);
            
        }

        public List<SellerDto> GetAll()
        {
            var sellers = _database.Sellers;

            var sellerDtoList = new List<SellerDto>();

            foreach (var seller in sellers)
            {
                var sellersCompany = _database.Companies.FirstOrDefault(x => x.Id == seller.CompanyId);
                
                var sellerDto = new SellerDto
                {
                    Id = seller.Id,
                    FullName = seller.FullName,
                    Email = seller.Email,
                    CompanyName = sellersCompany != null ? sellersCompany.Name : "DELETED"
                };

                sellerDtoList.Add(sellerDto);
            }

            return sellerDtoList;
        }

        public SellerDto Get(int id)
        {
            var seller = _database.Sellers.FirstOrDefault(x => x.Id == id);
            var sellersCompany = _database.Companies.FirstOrDefault(x => x.Id == seller.CompanyId);

            var sellerDto = new SellerDto
            {
                Id = seller.Id,
                FullName = seller.FullName,
                Email = seller.Email,
                CompanyName = sellersCompany.Name
            };

            return sellerDto;

        }

        public void Delete(int id)
        {
            _database.Sellers.Remove(_database.Sellers.FirstOrDefault(x => x.Id == id));
            
        }


    }
}
