# creates build/html
rm -r build -errorAction ignore
$d = mkdir build
$d = mkdir build/html
cp -r Content build/html/
cp -r *.css build/html/
cp -r *.html build/html/