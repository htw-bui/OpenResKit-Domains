﻿#region License

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at
//  
// http://www.apache.org/licenses/LICENSE-2.0.html
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  
// Copyright (c) 2013, HTW Berlin

#endregion

using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using OpenResKit.DomainModel;

namespace OpenResKit.Noise
{
  [Export(typeof (IDomainEntityConfiguration))]
  public class NoiseMeasurementConfiguration : EntityTypeConfiguration<NoiseMeasurement>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }
  
  [Export(typeof (IDomainEntityConfiguration))]
  public class NoiseMapPositionConfiguration : EntityTypeConfiguration<NoiseMapPosition>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class MeasuringMethodConfiguration: EntityTypeConfiguration<MeasuringMethod>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class MeasuringPointConfiguration : EntityTypeConfiguration<MeasuringPoint>, IDomainEntityConfiguration
  {
    public MeasuringPointConfiguration()
    {
      HasOptional(c => c.Position)
        .WithOptionalDependent()
        .WillCascadeOnDelete();
    }
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class NoiseMapConfiguration : EntityTypeConfiguration<NoiseMap>, IDomainEntityConfiguration
  {
    public NoiseMapConfiguration()
    {
      HasOptional(c => c.File)
        .WithOptionalDependent()
        .WillCascadeOnDelete();
    }
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }

  [Export(typeof (IDomainEntityConfiguration))]
  public class FileConfiguration : EntityTypeConfiguration<File>, IDomainEntityConfiguration
  {
    public void AddConfigurationToModel(ConfigurationRegistrar configurations)
    {
      configurations.Add(this);
    }
  }
}