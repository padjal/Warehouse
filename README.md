# Warehouse
Warehouse is a windows forms application for warehouse management which allows to categorise products and keep track of their availability in stock.

The project was created as a part of my university course as an individual peergrading assignment.

# Project Details
The main project form contains the two main interactive areas of the application - a TreeView control used for keeping track of all the available categories and a DatagridView, which displays all the products in the selected category and all of it's children. There is a MenuStrip, which contains all other available functions of the app. In order to accomplish some of the functionalities, additional forms are used.

# Available functionalities
 - Create, Edit and Delete Categories
 - Create and Edit Products
 - View all products in the given category as well as all of its descendants
 - Export as a CSV file all products, which need to be restocked. By default this number is set to 10, but can be changed in Tools>Options.
 - Saving state.

# To be added
 - Delete all subcategories and products when deleting a category
 - Delete products
 - Randomly generate data
 - Import data from files
 - Support images
 - Sorting