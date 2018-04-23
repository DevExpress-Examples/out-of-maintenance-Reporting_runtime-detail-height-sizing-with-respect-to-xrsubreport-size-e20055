# Runtime detail height sizing with respect to XRSubreport size


<p>In a single detail band an XRLabel and XRSubreport are placed side-by-side. The goal is to resize the XRLabel height to match the accompanying XRSubreport. This may be accomplished by calling CreateDocument twice. The first call sums the brick height of each subreport section and adds this float value to the dictionary under its category key. On the second CreateDocument call, the DetailBand.BeforePrint handler resizes each detail from the section sizes in the dictionary.</p>

<br/>


