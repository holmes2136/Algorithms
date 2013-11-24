Algorithms
==========


有關餘弦相似性的方法 , cosineSimilarityByTermFreq 是單純採用字頻的方式 , 
之後會再補上使用 TF-IDF 的方式 , 因為 TF-IDF 的方式是建立在特殊目的的字庫情況下
才有其效果 , 例如今天我們是要比對兩則新聞 , 比對的內容是屬於新聞的領域 , 
因此我們可以建立新聞的相關字庫 , 如此一來 , TF-IDF 才有其效果 



若是要比對"短字串"之間的相似性 , 可以使用 JaroWinklerDistance 或者 LevenshteinDistance , 
若讀者有興趣 , 也可以找尋 N-Gram 演算法來計算兩字串的相似性
