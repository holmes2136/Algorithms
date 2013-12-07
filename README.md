Algorithms
==========


有關餘弦相似性的方法集中在 TFIDF Class :

cosineSimilarityByTermFreq 

```
單純採用"字頻"的方式計算餘弦相似性
```

cosineSimilarityByTFIDF 

```
使用 TF-IDF 來計算餘弦相似性 , 適合使用在已經建立特定領域的語料庫的情況下 , 
例如今天我們是要比對兩則新聞 , 比對的內容是屬於新聞的領域 , 因此我們可以建
立新聞的相關字庫 , 如此一來 , TF-IDF 才有其效果 
```

cosineSimilarityByWFIDF 

==========



```
另外在使用 以上 方法時 , 筆者使用了 Lucene.Net 3.03 , 其必須在
.Net FrameWork 4.0 以上的版本 , 而 Lucene.Net 在此可以幫我們建立語料庫以及計算 TF-IDF 等
```

```
若是要比對"短字串"之間的相似性 , 可以使用 JaroWinklerDistance 或者 LevenshteinDistance , 
若讀者有興趣 , 也可以找尋 N-Gram 演算法來計算兩字串的相似性
```
