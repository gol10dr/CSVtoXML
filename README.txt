------
README
------

Summary
=======

This is a simple utility to convert CSV files containing variable attributes into 
an XML format for use with SolidWorks EPDM.  Currently this tool can import for a 
single vault name and up to 5 variables with values.

CSV Format
==========

The CSV file should match the following format for each row:

id,idattribute,idcfgname,configuration,attribute1,value1,attribute2,value2,attribute3,value3,attribute4,value4,attribute5,value5,

NOTE: The CSV file should NOT include a header row and empty values she be left blank (,,)

Description of Columns
======================

id = Matching variable value (ie. testpart.sldprt)

idattribute = Matching variable name (ie. filename)

idcfgname = Matching file's config name (leave blank for default)

configuration = File's config to modify

attribute = Variable name to write to (ie. description)

value = Variable value to write (ie. Left bracket side)