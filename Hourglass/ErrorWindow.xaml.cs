﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorWindow.xaml.cs" company="Chris Dziemborowicz">
//   Copyright (c) Chris Dziemborowicz. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Hourglass
{
    using System.Windows;

    /// <summary>
    /// A window that displays an error.
    /// </summary>
    public partial class ErrorWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorWindow"/> class.
        /// </summary>
        public ErrorWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the window and returns only when the window is closed.
        /// </summary>
        /// <param name="message">An error message.</param>
        /// <param name="details">Details of the error. (Optional.)</param>
        public void ShowDialog(string message, string details = null)
        {
            this.MessageTextBlock.Text = message;
            this.DetailsTextBox.Text = details ?? string.Empty;
            this.DetailsButton.IsEnabled = !string.IsNullOrEmpty(details);

            this.ShowDialog();
        }

        /// <summary>
        /// Invoked when the <see cref="DetailsButton"/> is clicked.
        /// </summary>
        /// <param name="sender">The <see cref="DetailsButton"/>.</param>
        /// <param name="e">The event data.</param>
        private void DetailsButtonClick(object sender, RoutedEventArgs e)
        {
            if (this.DetailsScrollViewer.Visibility != Visibility.Visible)
            {
                this.DetailsScrollViewer.Visibility = Visibility.Visible;
                this.DetailsButton.IsEnabled = false;
            }
        }
    }
}