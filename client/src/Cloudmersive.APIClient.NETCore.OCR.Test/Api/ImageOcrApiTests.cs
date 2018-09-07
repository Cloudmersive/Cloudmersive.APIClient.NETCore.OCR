/* 
 * ocrapi
 *
 * The powerful Optical Character Recognition (OCR) APIs let you convert scanned images of pages into recognized text.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Model;

namespace Cloudmersive.APIClient.NETCore.OCR.Test
{
    /// <summary>
    ///  Class for testing ImageOcrApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ImageOcrApiTests
    {
        private ImageOcrApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ImageOcrApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ImageOcrApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ImageOcrApi
            //Assert.IsInstanceOfType(typeof(ImageOcrApi), instance, "instance is a ImageOcrApi");
        }

        
        /// <summary>
        /// Test ImageOcrImageLinesWithLocation
        /// </summary>
        [Test]
        public void ImageOcrImageLinesWithLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //string language = null;
            //var response = instance.ImageOcrImageLinesWithLocation(imageFile, language);
            //Assert.IsInstanceOf<ImageToLinesWithLocationResult> (response, "response is ImageToLinesWithLocationResult");
        }
        
        /// <summary>
        /// Test ImageOcrImageWordsWithLocation
        /// </summary>
        [Test]
        public void ImageOcrImageWordsWithLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //string language = null;
            //var response = instance.ImageOcrImageWordsWithLocation(imageFile, language);
            //Assert.IsInstanceOf<ImageToWordsWithLocationResult> (response, "response is ImageToWordsWithLocationResult");
        }
        
        /// <summary>
        /// Test ImageOcrPhotoToText
        /// </summary>
        [Test]
        public void ImageOcrPhotoToTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //string language = null;
            //var response = instance.ImageOcrPhotoToText(imageFile, language);
            //Assert.IsInstanceOf<ImageToTextResponse> (response, "response is ImageToTextResponse");
        }
        
        /// <summary>
        /// Test ImageOcrPost
        /// </summary>
        [Test]
        public void ImageOcrPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //string language = null;
            //string preprocessing = null;
            //var response = instance.ImageOcrPost(imageFile, language, preprocessing);
            //Assert.IsInstanceOf<ImageToTextResponse> (response, "response is ImageToTextResponse");
        }
        
    }

}
