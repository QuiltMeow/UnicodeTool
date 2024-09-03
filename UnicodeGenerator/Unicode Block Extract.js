// https://zh.wikipedia.org/wiki/Unicode%E5%8D%80%E6%AE%B5
$("table tr").each(function () {
	let block = $(this).find("td").eq(0).text();
	let range = $(this).find("td").eq(1).text();
	if (!range.includes("U+")) {
		return;
	}
	let name = $(this).find("td").eq(2).text();
	console.log(block + "\t" + range.replace("..", "～") + "\t" + name.replace("-", "－"));
});