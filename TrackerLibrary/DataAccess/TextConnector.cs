﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        /// <summary>
        /// Save a new prize to a text file.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}