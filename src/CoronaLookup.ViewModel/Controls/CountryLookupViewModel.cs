﻿using System.Collections.Generic;
using CoronaLookup.Model;
using CoronaLookup.Repository;

namespace CoronaLookup.ViewModel.Controls
{
  public class CountryLookupViewModel
  {
    public delegate void CountryAddedDelegate(Country country);
    public event CountryAddedDelegate CountryAdded;

    private readonly CountryLookupModel mModel;

    public CountryLookupViewModel(CountryLookupModel model)
    {
      mModel = model;
    }

    public void SetRepository(string repoName)
    {
      mModel.SetRepository(repoName);
    }

    public void AddCountryToList(Country country)
    {
      if (country != null)
      {
        CountryAdded?.Invoke(country);
      }
    }

    public IList<Country> GetCountries()
    {
      return mModel.GetCountries();
    }

    public void SetCsvPath(string fileName)
    {
      mModel.SetCsvPath(fileName);
    }
  }
}