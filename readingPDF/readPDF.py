import PyPDF2

file = open("test.pdf", "rb")

reader = PyPDF2.PdfFileReader(file)

first_page = reader.getPage(0)
last_page = reader.getPage(reader.numPages - 1)

print("Number of pages: ", reader.numPages)
print("Data from first page:", first_page.extractText())
print("Data from last page:", last_page.extractText())

assert "page" in last_page.extractText()
