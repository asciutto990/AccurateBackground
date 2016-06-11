using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccurateBackground.Enums;
using AccurateBackground.Http;
using AccurateBackground.InputModels;
using AccurateBackground.Models;
using AccurateBackground.Resources;

namespace AccurateBackground
{
    public static class AccurateBackgroundAPI
    {
        /// <summary>
        /// The Alive resource is a simple 'ping’ API call to connect to the platform for testing purposes. Alive can be called without basic auth.
        /// </summary>
        /// <returns></returns>
        public static Task<bool> AliveAsync()
        {
            return AccurateCrudOperations.GetAsync<bool>("alive");
        }

        public static Task<Candidate> GetCandidateAsync(string candidateId)
        {
            return AccurateCrudOperations.GetAsync<Candidate>("candidate/" + candidateId);
        }

        public static Task<Candidate> GetCandidatesAsync()
        {
            return AccurateCrudOperations.GetAsync<Candidate>("candidate");
        }

        /// <summary>
        /// This is used create a new candidate to use in any number of background check orders and searches.
        /// The candidate can be created with a minimum set of information, and additional information can be added via API later, 
        /// or in the INTERACTIVE workflow, the applicant may add the needed personal information directly through a secure web form.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Task<Candidate> CreateCandidateAsync(CandidateInput input)
        {
            return AccurateCrudOperations.CreateAsync<CandidateInput, Candidate>("candidate", input);
        }

        /// <summary>
        /// To add additional optional information, such as a government id, after the candidate has been created.
        /// </summary>
        /// <param name="candidateId"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Task<Candidate> UpdateCandidateAsync(string candidateId, CandidateInput input)
        {
            return AccurateCrudOperations.UpdateAsync<CandidateInput, Candidate>("candidate/" + candidateId, input);
        }

        /// <summary>
        /// Check on the status of an Order, and all the searches within that order. Some searches require more Candidate information in order to run.
        /// If any search contained in the Order requires more information, the “candidateInfoComplete” filed in the Order will remain set to “false”, the Order will not run, and the Order status will remain “incomplete”.
        /// Check the status of the Order to look for status “incomplete”, then refer to the reference to determine what additional Candidate info is required. 
        /// If the Order workflow was “INTERACTIVE”, this may mean that the Candidate has not entered the required information in the secure web data entry form.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public static Task<Order> GetOrderAsync(string orderId)
        {
            return AccurateCrudOperations.GetAsync<Order>("order/" + orderId);
        }

        /// <summary>
        /// The Order resource represents your order to complete a background check on a specific Candidate, with your choice of search package and zero or more optional search additions.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Task<Order> PlaceOrderAsync(OrderInput input)
        {
            return AccurateCrudOperations.CreateAsync<OrderInput, Order>("order", input);
        }

        /// <summary>
        /// Get an individual product.
        /// </summary>
        /// <param name="productType"></param>
        /// <returns></returns>
        public static ProductView GetProduct(string productType)
        {
            var productTypes = ProductType.GetProductTypes();
            if (productTypes.All(p => p != productType))
                throw new InvalidOperationException("Product type does not exist.");

            return new ProductView(productType);
        }

        /// <summary>
        /// Get all products.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ProductView> GetProducts()
        {
            var productTypes = ProductType.GetProductTypes();
            return productTypes.Select(p => new ProductView(p));
        }
    }
}
