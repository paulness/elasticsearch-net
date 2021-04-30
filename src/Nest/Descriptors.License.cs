/*
 * Licensed to Elasticsearch B.V. under one or more contributor
 * license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright
 * ownership. Elasticsearch B.V. licenses this file to you under
 * the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.LicenseApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html</para></summary>
	public partial class DeleteLicenseDescriptor : RequestDescriptorBase<DeleteLicenseDescriptor, DeleteLicenseRequestParameters, IDeleteLicenseRequest>, IDeleteLicenseRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseDelete;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html</para></summary>
	public partial class GetLicenseDescriptor : RequestDescriptorBase<GetLicenseDescriptor, GetLicenseRequestParameters, IGetLicenseRequest>, IGetLicenseRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseGet;
		// values part of the url path
		// Request parameters
		///<summary>If the active license is an enterprise license, return type as 'enterprise' (default: false)</summary>
		public GetLicenseDescriptor AcceptEnterprise(bool? acceptenterprise = true) => Qs("accept_enterprise", acceptenterprise);
		///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
		public GetLicenseDescriptor Local(bool? local = true) => Qs("local", local);
	}

	///<summary>Descriptor for GetBasicStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html</para></summary>
	public partial class GetBasicLicenseStatusDescriptor : RequestDescriptorBase<GetBasicLicenseStatusDescriptor, GetBasicLicenseStatusRequestParameters, IGetBasicLicenseStatusRequest>, IGetBasicLicenseStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseGetBasicStatus;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for GetTrialStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html</para></summary>
	public partial class GetTrialLicenseStatusDescriptor : RequestDescriptorBase<GetTrialLicenseStatusDescriptor, GetTrialLicenseStatusRequestParameters, IGetTrialLicenseStatusRequest>, IGetTrialLicenseStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseGetTrialStatus;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for Post <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html</para></summary>
	public partial class PostLicenseDescriptor : RequestDescriptorBase<PostLicenseDescriptor, PostLicenseRequestParameters, IPostLicenseRequest>, IPostLicenseRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicensePost;
		// values part of the url path
		// Request parameters
		///<summary>whether the user has acknowledged acknowledge messages (default: false)</summary>
		public PostLicenseDescriptor Acknowledge(bool? acknowledge = true) => Qs("acknowledge", acknowledge);
	}

	///<summary>Descriptor for StartBasic <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html</para></summary>
	public partial class StartBasicLicenseDescriptor : RequestDescriptorBase<StartBasicLicenseDescriptor, StartBasicLicenseRequestParameters, IStartBasicLicenseRequest>, IStartBasicLicenseRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseStartBasic;
		// values part of the url path
		// Request parameters
		///<summary>whether the user has acknowledged acknowledge messages (default: false)</summary>
		public StartBasicLicenseDescriptor Acknowledge(bool? acknowledge = true) => Qs("acknowledge", acknowledge);
	}

	///<summary>Descriptor for StartTrial <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html</para></summary>
	public partial class StartTrialLicenseDescriptor : RequestDescriptorBase<StartTrialLicenseDescriptor, StartTrialLicenseRequestParameters, IStartTrialLicenseRequest>, IStartTrialLicenseRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseStartTrial;
		// values part of the url path
		// Request parameters
		///<summary>whether the user has acknowledged acknowledge messages (default: false)</summary>
		public StartTrialLicenseDescriptor Acknowledge(bool? acknowledge = true) => Qs("acknowledge", acknowledge);
		///<summary>The type of trial license to generate (default: "trial")</summary>
		public StartTrialLicenseDescriptor TypeQueryString(string typequerystring) => Qs("type", typequerystring);
	}
}