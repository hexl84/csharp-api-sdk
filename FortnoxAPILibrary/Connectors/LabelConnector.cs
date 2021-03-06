﻿using System.Collections.Generic;

namespace FortnoxAPILibrary.Connectors {
    /// <remarks/>
    public class LabelConnector : EntityConnector<Label, Labels, Sort.By.Label> {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string Id { get; set; }

        /// <remarks/>
        public LabelConnector() {
            base.Resource = "labels";
        }

        /// <summary>
        /// Gets a Label by ID
        /// </summary>
        /// <param name="labelId"></param>
        /// <returns></returns>
        public Label Get(string labelId, string accessToken, string clientSecret) {
            return base.BaseGet(accessToken, clientSecret, labelId);
        }

        /// <summary>
        /// Updates a label
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public Label Update(Label label, string accessToken, string clientSecret) {
            return base.BaseUpdate(label, accessToken,clientSecret, label.Id);
        }

        /// <summary>
        /// Create a new label
        /// </summary>
        /// <param name="label">The label entity to create</param>
        /// <returns>The created label.</returns>
        public Label Create(Label label, string accessToken, string clientSecret) {
            return base.BaseCreate(label, accessToken, clientSecret);
        }

        /// <summary>
        /// Delete a label
        /// </summary>
        /// <param name="labelid">The label id to delete</param>
        /// <returns>If the label was deleted. </returns>
        public void Delete(string labelid, string accessToken, string clientSecret) {
            base.BaseDelete(labelid,accessToken,clientSecret);
        }

        /// <summary>
        /// Gets a list of labels
        /// </summary>
        /// <returns>A list of labels</returns>
        public Labels Find(string accessToken, string clientSecret) {
            return base.BaseFind(accessToken, clientSecret);
        }
    }
}
