<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604692/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20055)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Runtime detail height sizing with respect to XRSubreport size


<p>In a single detail band an XRLabel and XRSubreport are placed side-by-side. The goal is to resize the XRLabel height to match the accompanying XRSubreport. This may be accomplished by calling CreateDocument twice. The first call sums the brick height of each subreport section and adds this float value to the dictionary under its category key. On the second CreateDocument call, the DetailBand.BeforePrint handler resizes each detail from the section sizes in the dictionary.</p>

<br/>


